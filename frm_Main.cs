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
		Hotkeys hook;
		Boolean snipper_open;
				
		#region Main Form
		public frm_Main()
		{
			InitializeComponent();
			
			// Delete older executable on update
			try {
				if(Convert.ToInt32(Settings.Read("hyperdesktop2", "build")) < Settings.build) {
					File.Delete(Settings.exe_path);
					Settings.Write("hyperdesktop2", "build", Settings.build.ToString());
				}
			} catch (Exception ex) {
				Console.WriteLine("Couldn't delete old hyperdesktop2 executable.");
				Console.WriteLine(ex.Message);
			}
			
			Global_Func.app_data_folder_create();
			Global_Func.copy_files();
			
			var web_client = new WebClient();
			Int32 build = Convert.ToInt32(web_client.DownloadString(Settings.build_url));
			
			// Confirm if user wants to add to system startup
			// on first run
			if(!File.Exists(Settings.ini_path)) {
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
			// Update notification
			else if(build > Settings.build) {
				DialogResult result = MessageBox.Show(
					"A new version of Hyperdesktop2 has been released. Would you like to download it?",
					"Update available",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result == DialogResult.Yes) {
					Process.Start(Settings.release_url);
					Process.GetCurrentProcess().Kill();
				}
			}
			
			register_hotkeys();
		}
		
		void Frm_MainLoad(object sender, EventArgs e)
		{
            Imgur.web_client.UploadProgressChanged += upload_progress_changed;
            Imgur.web_client.UploadValuesCompleted += upload_progress_complete;

			Settings.get_settings();
			tray_icon.Visible = true;

            Screen_Bounds.load();
		}
		
		void Frm_MainFormClosing(object sender, FormClosingEventArgs e)
		{
			inverse_tray_options(sender, e);
			e.Cancel = true;
		}
		#endregion
		
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
        void inverse_tray_options(object sender, EventArgs e)
        {
            minimizeToTrayToolStripMenuItem.Text = (minimizeToTrayToolStripMenuItem.Text == "Open Window") ? "Minimize to Tray" : "Open Window";

            ShowInTaskbar = !ShowInTaskbar;
            Opacity = Opacity < 1 ? 100 : 0;
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
		
		#region Hotkeys
		public void register_hotkeys()
		{
			hook = new Hotkeys();
			hook.KeyPressed += hook_KeyPressed;
			
			try {
				hook.RegisterHotKey(global::ModifierKeys.Control | global::ModifierKeys.Shift, Keys.D3);
				hook.RegisterHotKey(global::ModifierKeys.Control | global::ModifierKeys.Shift, Keys.D4);
				hook.RegisterHotKey(global::ModifierKeys.Control | global::ModifierKeys.Shift, Keys.D5);
			} catch {
				MessageBox.Show("Couldn't register hotkeys. Perhaps they are already in use or try running as an Administrator.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void hook_KeyPressed(object sender, KeyPressedEventArgs e)
	    {
			switch(e.Key) {
				case Keys.D3:
					screen_capture("screen");
					break;
					
				case Keys.D4:
					screen_capture("region");
					break;
					
				case Keys.D5:
					screen_capture("window");
					break;
			}
	    }
		#endregion

        #region Image

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
            if (!Settings.save_screenshots)
                return;

            if (name == null)
                name = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");

            try
            {
                bmp.Save(
                    String.Format("{0}/{1}.{2}", Settings.save_folder, name, Settings.save_format),
                    Global_Func.ext_to_imageformat(Settings.save_format)
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot save image.");
                Console.WriteLine(ex.Message);
            }
        }

        void screen_capture(String type)
        {
            Bitmap bmp = null;

            switch (type)
            {
                case "screen":
                    bmp = Screen_Capture.screen(Settings.show_cursor);
                    break;

                case "window":
                    bmp = Screen_Capture.window(Settings.show_cursor);
                    break;

                default:
                    if (snipper_open)
                        return;

                    snipper_open = true;
                    var rect = frm_Snipper.get_region();

                    if(rect == new Rectangle(0, 0, 0, 0))
                        return;

                    bmp = Screen_Capture.region(rect);
                    snipper_open = false;
                    break;
            }
            work_image(bmp, true);
        }

        void work_image(Bitmap bmp, Boolean edit = false)
        {
            Global_Func.play_sound("capture.wav");

            if (edit)
                bmp = edit_screenshot(bmp);

            if (bmp == null)
                return;

            if (Settings.upload_method == "imgur")
                if (!Imgur.upload(bmp))
                {
                    Global_Func.play_sound("error.wav");

                    if (Settings.balloon_messages)
                        balloon_tip("Error uploading file!", "Error", 2000, ToolTipIcon.Error);
                }

            save_screenshot(bmp);
        }
        #endregion
        
        #region Buttons
        void Btn_browseClick(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog();
			dialog.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp|All Files (*.*)|*.*"; 
			
			if(dialog.ShowDialog() == DialogResult.OK) {
				work_image(new Bitmap(Image.FromFile(dialog.FileName)));
			}	
		} 
		
		void Btn_captureClick(object sender, EventArgs e) 			{ screen_capture("screen"); }
		void Btn_windowClick() 										{ screen_capture("window"); }
		void Btn_capture_regionClick(object sender, EventArgs e) 	{ screen_capture("region"); }
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
		void RegisterHotkeysToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			register_hotkeys();
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
			
			if(Imgur.delete(list_image_links.SelectedItems[0].SubItems[1].Text))
				list_image_links.SelectedItems[0].Remove();
            else
            {
                Global_Func.play_sound("error.wav");

                if (Settings.balloon_messages)
                    balloon_tip("Could not delete file!", "Error", 2000, ToolTipIcon.Error);
            }
		}
		#endregion
		
		#region Progress Bar
		void upload_progress_changed(object sender, UploadProgressChangedEventArgs e)
		{
			try {
				Int32 percent = Convert.ToInt32(e.BytesSent / e.TotalBytesToSend) * 100;
				group_upload_progress.Text = String.Format("Upload Progress - {0}% ({1}kb/{2}kb)", percent, e.BytesSent / 1024, e.TotalBytesToSend / 1024);
				progress.Value = percent;
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
			
			String delete_hash = Global_Func.get_text_inbetween(response, "deletehash\":\"", "\",\"name\"").Replace("\\", "");
			String link 		= Global_Func.get_text_inbetween(response, "link\":\"", "\"}").Replace("\\", "");
			
			list_image_links.Items.Add(
				new ListViewItem(new String[] {link, delete_hash})
			);
			
			list_image_links.Items[list_image_links.Items.Count-1].EnsureVisible();
			
			if(Settings.copy_links_to_clipboard)
				Clipboard.SetText(link);
		
			if(Settings.balloon_messages)
				balloon_tip(link, "Upload Complete!", 2000);
			
			Global_Func.play_sound("success.wav");
		}
		#endregion
	}
}
