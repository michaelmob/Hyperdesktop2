using System;
using System.IO;
using System.Net;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Specialized;

namespace hyperdesktop2
{
	
	public partial class frm_Main : Form
	{
		
		#region Tray Icon
		void balloon_tip(String text, String title, Int32 duration, ToolTipIcon icon = ToolTipIcon.Info) {
			tray_icon.BalloonTipText = text;
			tray_icon.BalloonTipTitle = title;
			tray_icon.BalloonTipIcon = icon;
			tray_icon.ShowBalloonTip(duration);
		}
		void Tray_iconBalloonTipClicked(object sender, System.EventArgs e)
		{
			Process.Start(tray_icon.BalloonTipText);
		}
		#endregion
		
		#region Drag and Drop
		void drag_enter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
		}
		void drag_drop(object sender, DragEventArgs e)
		{
			var files = (String[])e.Data.GetData(DataFormats.FileDrop);
			
			foreach(String file in files) {
				work_image(new Bitmap(Image.FromFile(file)));
			}
		}
		#endregion
		
		#region Main Form
		public frm_Main()
		{
			InitializeComponent();
			
			if(!File.Exists(Environment.CurrentDirectory + "/hyperdesktop2.ini")) {
				DialogResult result = MessageBox.Show(
					"Do you want to run Hyperdesktop2 at Windows startup?",
					"First time run",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result == DialogResult.Yes)
					Global_Func.run_at_startup(true);
			}
	
			var hook = new Hotkeys();
			hook.KeyPressed += hook_KeyPressed;
			
			try {
				hook.RegisterHotKey(global::ModifierKeys.Control | global::ModifierKeys.Shift, Keys.D3);
				hook.RegisterHotKey(global::ModifierKeys.Control | global::ModifierKeys.Shift, Keys.D4);
				hook.RegisterHotKey(global::ModifierKeys.Control | global::ModifierKeys.Shift, Keys.D5);
			} catch {
				MessageBox.Show("Couldn't register hotkeys. Try running as an Administrator.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void hook_KeyPressed(object sender, KeyPressedEventArgs e)
	    {
			switch(e.Key) {
				case Keys.D3:
					btn_capture.PerformClick();
					break;
					
				case Keys.D4:
					btn_capture_selected_area.PerformClick();
					break;
					
				case Keys.D5:
					Btn_windowClick();
					break;
			}
	    }
		
		void Frm_MainLoad(object sender, EventArgs e)
		{
			Settings.get_settings();
			tray_icon.Visible = true;
			
			Snipper.initialize();
		}
		#endregion
		
		#region Upload Images
		void Btn_browseClick(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog();
			dialog.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp|All Files (*.*)|*.*"; 
			
			if(dialog.ShowDialog() == DialogResult.OK) {
				work_image(new Bitmap(Image.FromFile(dialog.FileName)));
			}	
		}
		#endregion
		
		#region Screenshot
		Bitmap edit_screenshot(Bitmap bmp)
		{
			if (!Settings.edit_screenshot)
				return null;
			
			var edit = new frm_Edit(bmp);
			edit.ShowDialog();
			
			return edit.Result;
		}
		
		void save_screenshot(Bitmap bmp, String name = null)
		{
			if(!Settings.save_screenshots)
				return;
			
			if(name == null)
				name = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
			
			bmp.Save(
				String.Format("{0}/{1}.{2}", Settings.save_folder, name, Settings.save_format),
				Global_Func.ext_to_imageformat(Settings.save_format)
			);
		}
		
		void work_image(Bitmap bmp) {

			Global_Func.play_sound("capture.wav");
			
			bmp = edit_screenshot(bmp);
		
			if(bmp == null)
				return;
			
			if(Settings.upload_method == "imgur")
				imgur_upload(bmp);
			
			save_screenshot(bmp);
		}
		
		void Btn_windowClick()
		{
			Bitmap bmp = Screen_Capture.window();
			work_image(bmp);
		}
		
		void Btn_captureClick(object sender, EventArgs e)
		{
			Bitmap bmp = Screen_Capture.screen(Settings.show_cursor);
			work_image(bmp);
		}
		
		void Btn_capture_regionClick(object sender, EventArgs e)
		{
			Bitmap bmp = Screen_Capture.region(Snipper.get_region());
			work_image(bmp);
		}
		#endregion
		
		#region Main Menu
		void PreferencesToolStripMenuItemClick(object sender, EventArgs e)
		{
			new frm_Preferences().ShowDialog();
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			new frm_About().ShowDialog();
		}
		#endregion
		
		#region Tray Menu
		void inverse_tray_options(object sender, EventArgs e) {
			minimizeToTrayToolStripMenuItem.Text = (minimizeToTrayToolStripMenuItem.Text == "Open Window") ? "Minimize to Tray" : "Open Window";
			
			this.Visible = !this.Visible;
		}
		#endregion
		
		#region Image Links Menu
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(list_image_links.SelectedItems.Count > 0)
				Process.Start(list_image_links.SelectedItems[0].Text);
		}
		void CopyToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(list_image_links.SelectedItems.Count > 0)
				Clipboard.SetText(list_image_links.SelectedItems[0].Text);
		}
		void DeleteToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(list_image_links.SelectedItems.Count <= 0)
				return;
			
			if(imgur_delete(list_image_links.SelectedItems[0].SubItems[1].Text))
				list_image_links.SelectedItems[0].Remove();
		}
		#endregion
		
		#region Imgur Uploading
		void imgur_upload(Bitmap bmp)
		{
			try {
				var web_client = new WebClient();
				
				var data = new NameValueCollection();
				
				web_client.UploadProgressChanged += upload_progress_changed;
				web_client.UploadValuesCompleted += upload_progress_complete;
				
				var image = Global_Func.bmp_to_base64(bmp, Global_Func.ext_to_imageformat(Settings.upload_format));
				data.Add("image", image);
				
				web_client.Headers.Add("Authorization", "Client-ID " + Settings.imgur_client_id);
				web_client.UploadValuesAsync(
					new Uri("https://api.imgur.com/3/image/"),
					"POST",
					data
				);
				
				web_client.Dispose();
			} catch {
				Global_Func.play_sound("error.wav");
				
				if(Settings.balloon_messages)
					balloon_tip("Error uploading file!", "Error", 2000, ToolTipIcon.Error);
			}
		}
		
		Boolean imgur_delete(String delete_hash) 
		{
			try {
				var web_client = new WebClient();
				
				web_client.Headers.Add("Authorization", "Client-ID " + Settings.imgur_client_id);
				web_client.UploadData(
					new Uri("https://api.imgur.com/3/image/" + delete_hash),
					"DELETE",
					new Byte[] { 0x0 }
				);
				
				web_client.Dispose();
				return true;
			} catch {
				Global_Func.play_sound("error.wav");
				
				if(Settings.balloon_messages)
					balloon_tip("Could not delete file!", "Error", 2000, ToolTipIcon.Error);
				
				return false;
			}
		}
		
		void upload_progress_changed(object sender, ProgressChangedEventArgs e)
		{
			try {
				group_upload_progress.Text = String.Format("Upload Progress - {0}%", e.ProgressPercentage);
				progress.Value = e.ProgressPercentage;
			} catch {
				// below .NET 4.0, sometimes it throws an absurd
				// number into the ProgressPercentage
			}
		}
		
		void upload_progress_complete(object sender, UploadValuesCompletedEventArgs e)
		{
			group_upload_progress.Text = "Upload Progress";
			progress.Value = 0;
			
			String response = Encoding.UTF8.GetString(e.Result);
			
			String delete_hash 	= Global_Func.get_text_inbetween(response, "deletehash\":\"", "\",\"link\"").Replace("\\", "");
			String link 		= Global_Func.get_text_inbetween(response, "link\":\"", "\"}").Replace("\\", "");
			
			list_image_links.Items.Add(
				new ListViewItem(new String[] {link, delete_hash})
			);
			
			if(Settings.copy_links_to_clipboard)
				Clipboard.SetText(link);
		
			if(Settings.balloon_messages)
				balloon_tip(link, "Upload Complete!", 2000);
			
			Global_Func.play_sound("success.wav");
		}
		#endregion
	}
}
