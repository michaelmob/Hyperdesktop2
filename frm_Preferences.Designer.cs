/*
 * Created by SharpDevelop.
 * User: Mike
 * Date: 5/21/2014
 * Time: 6:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace hyperdesktop2
{
	partial class frm_Preferences
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Preferences));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tab_general = new System.Windows.Forms.TabPage();
			this.drop_save_quality = new System.Windows.Forms.ComboBox();
			this.label_save_quality = new System.Windows.Forms.Label();
			this.drop_save_format = new System.Windows.Forms.ComboBox();
			this.label_save_format = new System.Windows.Forms.Label();
			this.btn_browse_save_folder = new System.Windows.Forms.Button();
			this.txt_save_folder = new System.Windows.Forms.TextBox();
			this.check_save_screenshots = new System.Windows.Forms.CheckBox();
			this.tab_behavior = new System.Windows.Forms.TabPage();
			this.check_show_cursor = new System.Windows.Forms.CheckBox();
			this.check_edit_screenshot = new System.Windows.Forms.CheckBox();
			this.check_launch_browser = new System.Windows.Forms.CheckBox();
			this.check_balloon = new System.Windows.Forms.CheckBox();
			this.check_sound_effects = new System.Windows.Forms.CheckBox();
			this.check_copy_links = new System.Windows.Forms.CheckBox();
			this.check_run_at_startup = new System.Windows.Forms.CheckBox();
			this.tab_uploading = new System.Windows.Forms.TabPage();
			this.drop_upload_method = new System.Windows.Forms.ComboBox();
			this.label_upload_method = new System.Windows.Forms.Label();
			this.drop_upload_format = new System.Windows.Forms.ComboBox();
			this.label_update_format = new System.Windows.Forms.Label();
			this.tab_hotkeys = new System.Windows.Forms.TabPage();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label_screenshot = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.check_screenshot_ctrl = new System.Windows.Forms.CheckBox();
			this.label_hotkeys_instructions = new System.Windows.Forms.Label();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tab_general.SuspendLayout();
			this.tab_behavior.SuspendLayout();
			this.tab_uploading.SuspendLayout();
			this.tab_hotkeys.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tab_general);
			this.tabControl1.Controls.Add(this.tab_behavior);
			this.tabControl1.Controls.Add(this.tab_uploading);
			this.tabControl1.Controls.Add(this.tab_hotkeys);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(352, 211);
			this.tabControl1.TabIndex = 0;
			// 
			// tab_general
			// 
			this.tab_general.Controls.Add(this.drop_save_quality);
			this.tab_general.Controls.Add(this.label_save_quality);
			this.tab_general.Controls.Add(this.drop_save_format);
			this.tab_general.Controls.Add(this.label_save_format);
			this.tab_general.Controls.Add(this.btn_browse_save_folder);
			this.tab_general.Controls.Add(this.txt_save_folder);
			this.tab_general.Controls.Add(this.check_save_screenshots);
			this.tab_general.Location = new System.Drawing.Point(4, 22);
			this.tab_general.Name = "tab_general";
			this.tab_general.Padding = new System.Windows.Forms.Padding(3);
			this.tab_general.Size = new System.Drawing.Size(344, 185);
			this.tab_general.TabIndex = 0;
			this.tab_general.Text = "General";
			this.tab_general.UseVisualStyleBackColor = true;
			// 
			// drop_save_quality
			// 
			this.drop_save_quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.drop_save_quality.Enabled = false;
			this.drop_save_quality.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.drop_save_quality.FormattingEnabled = true;
			this.drop_save_quality.Items.AddRange(new object[] {
			"100",
			"90",
			"80",
			"70",
			"60",
			"50",
			"40",
			"30",
			"20",
			"10"});
			this.drop_save_quality.Location = new System.Drawing.Point(56, 88);
			this.drop_save_quality.Name = "drop_save_quality";
			this.drop_save_quality.Size = new System.Drawing.Size(121, 21);
			this.drop_save_quality.TabIndex = 6;
			// 
			// label_save_quality
			// 
			this.label_save_quality.Location = new System.Drawing.Point(8, 86);
			this.label_save_quality.Name = "label_save_quality";
			this.label_save_quality.Size = new System.Drawing.Size(42, 23);
			this.label_save_quality.TabIndex = 5;
			this.label_save_quality.Text = "Quality:";
			this.label_save_quality.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// drop_save_format
			// 
			this.drop_save_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.drop_save_format.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.drop_save_format.FormattingEnabled = true;
			this.drop_save_format.Items.AddRange(new object[] {
			"bmp",
			"png",
			"jpg"});
			this.drop_save_format.Location = new System.Drawing.Point(56, 61);
			this.drop_save_format.Name = "drop_save_format";
			this.drop_save_format.Size = new System.Drawing.Size(121, 21);
			this.drop_save_format.TabIndex = 4;
			// 
			// label_save_format
			// 
			this.label_save_format.Location = new System.Drawing.Point(8, 59);
			this.label_save_format.Name = "label_save_format";
			this.label_save_format.Size = new System.Drawing.Size(42, 23);
			this.label_save_format.TabIndex = 3;
			this.label_save_format.Text = "Format:";
			this.label_save_format.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_browse_save_folder
			// 
			this.btn_browse_save_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_browse_save_folder.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_browse_save_folder.Location = new System.Drawing.Point(261, 30);
			this.btn_browse_save_folder.Name = "btn_browse_save_folder";
			this.btn_browse_save_folder.Size = new System.Drawing.Size(75, 22);
			this.btn_browse_save_folder.TabIndex = 2;
			this.btn_browse_save_folder.Text = "browse";
			this.btn_browse_save_folder.UseVisualStyleBackColor = true;
			this.btn_browse_save_folder.Click += new System.EventHandler(this.Btn_browse_save_folderClick);
			// 
			// txt_save_folder
			// 
			this.txt_save_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_save_folder.Location = new System.Drawing.Point(8, 31);
			this.txt_save_folder.Name = "txt_save_folder";
			this.txt_save_folder.Size = new System.Drawing.Size(254, 20);
			this.txt_save_folder.TabIndex = 1;
			// 
			// check_save_screenshots
			// 
			this.check_save_screenshots.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.check_save_screenshots.Location = new System.Drawing.Point(8, 6);
			this.check_save_screenshots.Name = "check_save_screenshots";
			this.check_save_screenshots.Size = new System.Drawing.Size(328, 19);
			this.check_save_screenshots.TabIndex = 0;
			this.check_save_screenshots.Text = "Save Screenshots Automatically";
			this.check_save_screenshots.UseVisualStyleBackColor = true;
			this.check_save_screenshots.CheckedChanged += new System.EventHandler(this.Check_save_screenshotsCheckedChanged);
			// 
			// tab_behavior
			// 
			this.tab_behavior.Controls.Add(this.check_show_cursor);
			this.tab_behavior.Controls.Add(this.check_edit_screenshot);
			this.tab_behavior.Controls.Add(this.check_launch_browser);
			this.tab_behavior.Controls.Add(this.check_balloon);
			this.tab_behavior.Controls.Add(this.check_sound_effects);
			this.tab_behavior.Controls.Add(this.check_copy_links);
			this.tab_behavior.Controls.Add(this.check_run_at_startup);
			this.tab_behavior.Location = new System.Drawing.Point(4, 22);
			this.tab_behavior.Name = "tab_behavior";
			this.tab_behavior.Padding = new System.Windows.Forms.Padding(3);
			this.tab_behavior.Size = new System.Drawing.Size(344, 185);
			this.tab_behavior.TabIndex = 1;
			this.tab_behavior.Text = "Behavior";
			this.tab_behavior.UseVisualStyleBackColor = true;
			// 
			// check_show_cursor
			// 
			this.check_show_cursor.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.check_show_cursor.Location = new System.Drawing.Point(8, 56);
			this.check_show_cursor.Name = "check_show_cursor";
			this.check_show_cursor.Size = new System.Drawing.Size(316, 19);
			this.check_show_cursor.TabIndex = 6;
			this.check_show_cursor.Text = "Show cursor in screenshots";
			this.check_show_cursor.UseVisualStyleBackColor = true;
			// 
			// check_edit_screenshot
			// 
			this.check_edit_screenshot.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.check_edit_screenshot.Location = new System.Drawing.Point(8, 156);
			this.check_edit_screenshot.Name = "check_edit_screenshot";
			this.check_edit_screenshot.Size = new System.Drawing.Size(316, 19);
			this.check_edit_screenshot.TabIndex = 5;
			this.check_edit_screenshot.Text = "Edit screenshot after capture";
			this.check_edit_screenshot.UseVisualStyleBackColor = true;
			// 
			// check_launch_browser
			// 
			this.check_launch_browser.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.check_launch_browser.Location = new System.Drawing.Point(8, 131);
			this.check_launch_browser.Name = "check_launch_browser";
			this.check_launch_browser.Size = new System.Drawing.Size(316, 19);
			this.check_launch_browser.TabIndex = 4;
			this.check_launch_browser.Text = "Launch browser after upload";
			this.check_launch_browser.UseVisualStyleBackColor = true;
			// 
			// check_balloon
			// 
			this.check_balloon.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.check_balloon.Location = new System.Drawing.Point(8, 106);
			this.check_balloon.Name = "check_balloon";
			this.check_balloon.Size = new System.Drawing.Size(316, 19);
			this.check_balloon.TabIndex = 3;
			this.check_balloon.Text = "Enable balloon messages";
			this.check_balloon.UseVisualStyleBackColor = true;
			// 
			// check_sound_effects
			// 
			this.check_sound_effects.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.check_sound_effects.Location = new System.Drawing.Point(8, 81);
			this.check_sound_effects.Name = "check_sound_effects";
			this.check_sound_effects.Size = new System.Drawing.Size(316, 19);
			this.check_sound_effects.TabIndex = 2;
			this.check_sound_effects.Text = "Enable sound effects";
			this.check_sound_effects.UseVisualStyleBackColor = true;
			// 
			// check_copy_links
			// 
			this.check_copy_links.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.check_copy_links.Location = new System.Drawing.Point(8, 31);
			this.check_copy_links.Name = "check_copy_links";
			this.check_copy_links.Size = new System.Drawing.Size(316, 19);
			this.check_copy_links.TabIndex = 1;
			this.check_copy_links.Text = "Copy links to clipboard";
			this.check_copy_links.UseVisualStyleBackColor = true;
			// 
			// check_run_at_startup
			// 
			this.check_run_at_startup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.check_run_at_startup.Location = new System.Drawing.Point(8, 6);
			this.check_run_at_startup.Name = "check_run_at_startup";
			this.check_run_at_startup.Size = new System.Drawing.Size(316, 19);
			this.check_run_at_startup.TabIndex = 0;
			this.check_run_at_startup.Text = "Run at system startup";
			this.check_run_at_startup.UseVisualStyleBackColor = true;
			// 
			// tab_uploading
			// 
			this.tab_uploading.Controls.Add(this.drop_upload_method);
			this.tab_uploading.Controls.Add(this.label_upload_method);
			this.tab_uploading.Controls.Add(this.drop_upload_format);
			this.tab_uploading.Controls.Add(this.label_update_format);
			this.tab_uploading.Location = new System.Drawing.Point(4, 22);
			this.tab_uploading.Name = "tab_uploading";
			this.tab_uploading.Padding = new System.Windows.Forms.Padding(3);
			this.tab_uploading.Size = new System.Drawing.Size(344, 185);
			this.tab_uploading.TabIndex = 2;
			this.tab_uploading.Text = "Uploading";
			this.tab_uploading.UseVisualStyleBackColor = true;
			// 
			// drop_upload_method
			// 
			this.drop_upload_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.drop_upload_method.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.drop_upload_method.FormattingEnabled = true;
			this.drop_upload_method.Items.AddRange(new object[] {
			"do not upload",
			"imgur"});
			this.drop_upload_method.Location = new System.Drawing.Point(64, 6);
			this.drop_upload_method.Name = "drop_upload_method";
			this.drop_upload_method.Size = new System.Drawing.Size(121, 21);
			this.drop_upload_method.TabIndex = 8;
			// 
			// label_upload_method
			// 
			this.label_upload_method.Location = new System.Drawing.Point(8, 4);
			this.label_upload_method.Name = "label_upload_method";
			this.label_upload_method.Size = new System.Drawing.Size(50, 23);
			this.label_upload_method.TabIndex = 7;
			this.label_upload_method.Text = "Method:";
			this.label_upload_method.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// drop_upload_format
			// 
			this.drop_upload_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.drop_upload_format.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.drop_upload_format.FormattingEnabled = true;
			this.drop_upload_format.Items.AddRange(new object[] {
			"bmp",
			"png",
			"jpg"});
			this.drop_upload_format.Location = new System.Drawing.Point(64, 33);
			this.drop_upload_format.Name = "drop_upload_format";
			this.drop_upload_format.Size = new System.Drawing.Size(121, 21);
			this.drop_upload_format.TabIndex = 6;
			// 
			// label_update_format
			// 
			this.label_update_format.Location = new System.Drawing.Point(8, 31);
			this.label_update_format.Name = "label_update_format";
			this.label_update_format.Size = new System.Drawing.Size(50, 23);
			this.label_update_format.TabIndex = 5;
			this.label_update_format.Text = "Format:";
			this.label_update_format.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tab_hotkeys
			// 
			this.tab_hotkeys.Controls.Add(this.textBox3);
			this.tab_hotkeys.Controls.Add(this.label2);
			this.tab_hotkeys.Controls.Add(this.checkBox6);
			this.tab_hotkeys.Controls.Add(this.checkBox7);
			this.tab_hotkeys.Controls.Add(this.checkBox8);
			this.tab_hotkeys.Controls.Add(this.textBox2);
			this.tab_hotkeys.Controls.Add(this.label1);
			this.tab_hotkeys.Controls.Add(this.checkBox3);
			this.tab_hotkeys.Controls.Add(this.checkBox4);
			this.tab_hotkeys.Controls.Add(this.checkBox5);
			this.tab_hotkeys.Controls.Add(this.textBox1);
			this.tab_hotkeys.Controls.Add(this.label_screenshot);
			this.tab_hotkeys.Controls.Add(this.checkBox2);
			this.tab_hotkeys.Controls.Add(this.checkBox1);
			this.tab_hotkeys.Controls.Add(this.check_screenshot_ctrl);
			this.tab_hotkeys.Controls.Add(this.label_hotkeys_instructions);
			this.tab_hotkeys.Location = new System.Drawing.Point(4, 22);
			this.tab_hotkeys.Name = "tab_hotkeys";
			this.tab_hotkeys.Padding = new System.Windows.Forms.Padding(3);
			this.tab_hotkeys.Size = new System.Drawing.Size(344, 185);
			this.tab_hotkeys.TabIndex = 3;
			this.tab_hotkeys.Text = "Hotkeys";
			this.tab_hotkeys.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(300, 88);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(30, 20);
			this.textBox3.TabIndex = 15;
			this.textBox3.Text = "5";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "3. Take window screenshot";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox6
			// 
			this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox6.Checked = true;
			this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox6.Enabled = false;
			this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox6.Location = new System.Drawing.Point(247, 86);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(47, 24);
			this.checkBox6.TabIndex = 13;
			this.checkBox6.Text = "Shift";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// checkBox7
			// 
			this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox7.Enabled = false;
			this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox7.Location = new System.Drawing.Point(202, 86);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(39, 24);
			this.checkBox7.TabIndex = 12;
			this.checkBox7.Text = "Alt";
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// checkBox8
			// 
			this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox8.Checked = true;
			this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox8.Enabled = false;
			this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox8.Location = new System.Drawing.Point(154, 86);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(42, 24);
			this.checkBox8.TabIndex = 11;
			this.checkBox8.Text = "Ctrl";
			this.checkBox8.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(300, 58);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(30, 20);
			this.textBox2.TabIndex = 10;
			this.textBox2.Text = "4";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "2. Take region screenshot:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Enabled = false;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox3.Location = new System.Drawing.Point(247, 56);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(47, 24);
			this.checkBox3.TabIndex = 8;
			this.checkBox3.Text = "Shift";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox4.Enabled = false;
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox4.Location = new System.Drawing.Point(202, 56);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(39, 24);
			this.checkBox4.TabIndex = 7;
			this.checkBox4.Text = "Alt";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox5.Checked = true;
			this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox5.Enabled = false;
			this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox5.Location = new System.Drawing.Point(154, 56);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(42, 24);
			this.checkBox5.TabIndex = 6;
			this.checkBox5.Text = "Ctrl";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(300, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(30, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "3";
			// 
			// label_screenshot
			// 
			this.label_screenshot.Location = new System.Drawing.Point(8, 26);
			this.label_screenshot.Name = "label_screenshot";
			this.label_screenshot.Size = new System.Drawing.Size(140, 23);
			this.label_screenshot.TabIndex = 4;
			this.label_screenshot.Text = "1. Take screenshot:";
			this.label_screenshot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Enabled = false;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox2.Location = new System.Drawing.Point(247, 26);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(47, 24);
			this.checkBox2.TabIndex = 3;
			this.checkBox2.Text = "Shift";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox1.Enabled = false;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox1.Location = new System.Drawing.Point(202, 26);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(39, 24);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Alt";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// check_screenshot_ctrl
			// 
			this.check_screenshot_ctrl.Appearance = System.Windows.Forms.Appearance.Button;
			this.check_screenshot_ctrl.Checked = true;
			this.check_screenshot_ctrl.CheckState = System.Windows.Forms.CheckState.Checked;
			this.check_screenshot_ctrl.Enabled = false;
			this.check_screenshot_ctrl.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.check_screenshot_ctrl.Location = new System.Drawing.Point(154, 26);
			this.check_screenshot_ctrl.Name = "check_screenshot_ctrl";
			this.check_screenshot_ctrl.Size = new System.Drawing.Size(42, 24);
			this.check_screenshot_ctrl.TabIndex = 1;
			this.check_screenshot_ctrl.Text = "Ctrl";
			this.check_screenshot_ctrl.UseVisualStyleBackColor = true;
			// 
			// label_hotkeys_instructions
			// 
			this.label_hotkeys_instructions.Location = new System.Drawing.Point(8, 3);
			this.label_hotkeys_instructions.Name = "label_hotkeys_instructions";
			this.label_hotkeys_instructions.Size = new System.Drawing.Size(322, 23);
			this.label_hotkeys_instructions.TabIndex = 0;
			this.label_hotkeys_instructions.Text = "Set your own hotkeys here.";
			this.label_hotkeys_instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_save
			// 
			this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_save.Location = new System.Drawing.Point(191, 213);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(75, 23);
			this.btn_save.TabIndex = 1;
			this.btn_save.Text = "Okay";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.Btn_saveClick);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_cancel.Location = new System.Drawing.Point(273, 213);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_cancel.TabIndex = 2;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.Btn_cancelClick);
			// 
			// frm_Preferences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 240);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frm_Preferences";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preferences";
			this.Load += new System.EventHandler(this.Frm_PreferencesLoad);
			this.tabControl1.ResumeLayout(false);
			this.tab_general.ResumeLayout(false);
			this.tab_general.PerformLayout();
			this.tab_behavior.ResumeLayout(false);
			this.tab_uploading.ResumeLayout(false);
			this.tab_hotkeys.ResumeLayout(false);
			this.tab_hotkeys.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox drop_upload_method;
		private System.Windows.Forms.Label label_upload_method;
		private System.Windows.Forms.ComboBox drop_upload_format;
		private System.Windows.Forms.Label label_update_format;
		private System.Windows.Forms.CheckBox check_show_cursor;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label_screenshot;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox check_screenshot_ctrl;
		private System.Windows.Forms.Label label_hotkeys_instructions;
		private System.Windows.Forms.CheckBox check_edit_screenshot;
		private System.Windows.Forms.CheckBox check_launch_browser;
		private System.Windows.Forms.CheckBox check_balloon;
		private System.Windows.Forms.CheckBox check_sound_effects;
		private System.Windows.Forms.CheckBox check_copy_links;
		private System.Windows.Forms.CheckBox check_run_at_startup;
		private System.Windows.Forms.ComboBox drop_save_quality;
		private System.Windows.Forms.Label label_save_quality;
		private System.Windows.Forms.ComboBox drop_save_format;
		private System.Windows.Forms.Label label_save_format;
		private System.Windows.Forms.Button btn_browse_save_folder;
		private System.Windows.Forms.TextBox txt_save_folder;
		private System.Windows.Forms.CheckBox check_save_screenshots;
		private System.Windows.Forms.TabPage tab_hotkeys;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tab_general;
		private System.Windows.Forms.TabPage tab_behavior;
		private System.Windows.Forms.TabPage tab_uploading;
	}
}
