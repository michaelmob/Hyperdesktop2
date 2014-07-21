/*
 * Created by SharpDevelop.
 * User: Mike
 * Date: 5/21/2014
 * Time: 1:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace hyperdesktop2
{
	partial class frm_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Edit));
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_okay = new System.Windows.Forms.Button();
            this.label_size = new System.Windows.Forms.Label();
            this.drop_size = new System.Windows.Forms.ComboBox();
            this.drop_color = new System.Windows.Forms.ComboBox();
            this.label_color = new System.Windows.Forms.Label();
            this.text_insert = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_pen = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.check_drop_shadow = new System.Windows.Forms.CheckBox();
            this.picture_frame = new System.Windows.Forms.Panel();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.main_menu.SuspendLayout();
            this.panel.SuspendLayout();
            this.picture_frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(788, 24);
            this.main_menu.TabIndex = 0;
            this.main_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.submitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItemClick);
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.submitToolStripMenuItem.Text = "Submit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItemClick);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItemClick);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItemClick);
            // 
            // btn_okay
            // 
            this.btn_okay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_okay.Location = new System.Drawing.Point(3, 3);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(83, 23);
            this.btn_okay.TabIndex = 2;
            this.btn_okay.Text = "Okay";
            this.btn_okay.UseVisualStyleBackColor = true;
            this.btn_okay.Click += new System.EventHandler(this.Btn_okayClick);
            // 
            // label_size
            // 
            this.label_size.Location = new System.Drawing.Point(85, 3);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(34, 22);
            this.label_size.TabIndex = 3;
            this.label_size.Text = "Size:";
            this.label_size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drop_size
            // 
            this.drop_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_size.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drop_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_size.FormattingEnabled = true;
            this.drop_size.Location = new System.Drawing.Point(118, 3);
            this.drop_size.Name = "drop_size";
            this.drop_size.Size = new System.Drawing.Size(80, 23);
            this.drop_size.TabIndex = 4;
            this.drop_size.SelectedIndexChanged += new System.EventHandler(this.Drop_sizeSelectedIndexChanged);
            // 
            // drop_color
            // 
            this.drop_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_color.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drop_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_color.FormattingEnabled = true;
            this.drop_color.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green",
            "White",
            "Yellow"});
            this.drop_color.Location = new System.Drawing.Point(238, 3);
            this.drop_color.Name = "drop_color";
            this.drop_color.Size = new System.Drawing.Size(80, 23);
            this.drop_color.TabIndex = 6;
            this.drop_color.SelectedIndexChanged += new System.EventHandler(this.Drop_colorSelectedIndexChanged);
            // 
            // label_color
            // 
            this.label_color.Location = new System.Drawing.Point(206, 3);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(34, 23);
            this.label_color.TabIndex = 5;
            this.label_color.Text = "Color:";
            this.label_color.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_insert
            // 
            this.text_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_insert.Location = new System.Drawing.Point(395, 4);
            this.text_insert.Name = "text_insert";
            this.text_insert.Size = new System.Drawing.Size(220, 21);
            this.text_insert.TabIndex = 7;
            this.text_insert.Text = "Insert Text";
            this.text_insert.Click += new System.EventHandler(this.Text_insertClick);
            // 
            // btn_insert
            // 
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_insert.Location = new System.Drawing.Point(614, 3);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(76, 23);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "Insert Text";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.Btn_insertClick);
            // 
            // btn_pen
            // 
            this.btn_pen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_pen.Location = new System.Drawing.Point(323, 3);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(66, 23);
            this.btn_pen.TabIndex = 9;
            this.btn_pen.Text = "Pen";
            this.btn_pen.UseVisualStyleBackColor = true;
            this.btn_pen.Click += new System.EventHandler(this.Btn_penClick);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.check_drop_shadow);
            this.panel.Controls.Add(this.drop_size);
            this.panel.Controls.Add(this.drop_color);
            this.panel.Controls.Add(this.btn_okay);
            this.panel.Controls.Add(this.btn_pen);
            this.panel.Controls.Add(this.label_size);
            this.panel.Controls.Add(this.btn_insert);
            this.panel.Controls.Add(this.text_insert);
            this.panel.Controls.Add(this.label_color);
            this.panel.Location = new System.Drawing.Point(0, 505);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(788, 29);
            this.panel.TabIndex = 10;
            // 
            // check_drop_shadow
            // 
            this.check_drop_shadow.Location = new System.Drawing.Point(696, 4);
            this.check_drop_shadow.Name = "check_drop_shadow";
            this.check_drop_shadow.Size = new System.Drawing.Size(92, 21);
            this.check_drop_shadow.TabIndex = 10;
            this.check_drop_shadow.Text = "Drop Shadow";
            this.check_drop_shadow.UseVisualStyleBackColor = true;
            // 
            // picture_frame
            // 
            this.picture_frame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_frame.AutoScroll = true;
            this.picture_frame.BackColor = System.Drawing.Color.DimGray;
            this.picture_frame.Controls.Add(this.picture_box);
            this.picture_frame.Location = new System.Drawing.Point(0, 24);
            this.picture_frame.Name = "picture_frame";
            this.picture_frame.Size = new System.Drawing.Size(788, 481);
            this.picture_frame.TabIndex = 0;
            // 
            // picture_box
            // 
            this.picture_box.Location = new System.Drawing.Point(0, 0);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(467, 240);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_box.TabIndex = 0;
            this.picture_box.TabStop = false;
            this.picture_box.Paint += new System.Windows.Forms.PaintEventHandler(this.Picture_boxPaint);
            this.picture_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picture_boxMouseDown);
            this.picture_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_boxMouseMove);
            this.picture_box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Picture_boxMouseUp);
            // 
            // frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 535);
            this.Controls.Add(this.picture_frame);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.main_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.main_menu;
            this.Name = "frm_Edit";
            this.Text = "Edit Screenshot";
            this.Load += new System.EventHandler(this.Frm_EditLoad);
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.picture_frame.ResumeLayout(false);
            this.picture_frame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox check_drop_shadow;
		private System.Windows.Forms.PictureBox picture_box;
		private System.Windows.Forms.Panel picture_frame;
		private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
		private System.Windows.Forms.ComboBox drop_size;
		private System.Windows.Forms.ComboBox drop_color;
		private System.Windows.Forms.Label label_color;
		private System.Windows.Forms.TextBox text_insert;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.Button btn_pen;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.MenuStrip main_menu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.Button btn_okay;
		private System.Windows.Forms.Label label_size;
	}
}
