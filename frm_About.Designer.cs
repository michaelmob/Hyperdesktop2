/*
 * Created by SharpDevelop.
 * User: Mike
 * Date: 5/22/2014
 * Time: 3:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace hyperdesktop2
{
	partial class frm_About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_About));
			this.label_Hyperdesktop = new System.Windows.Forms.Label();
			this.label_motto = new System.Windows.Forms.Label();
			this.btn_github = new System.Windows.Forms.Button();
			this.label_build = new System.Windows.Forms.Label();
			this.btn_report = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_Hyperdesktop
			// 
			this.label_Hyperdesktop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_Hyperdesktop.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Hyperdesktop.Location = new System.Drawing.Point(12, 0);
			this.label_Hyperdesktop.Name = "label_Hyperdesktop";
			this.label_Hyperdesktop.Size = new System.Drawing.Size(378, 58);
			this.label_Hyperdesktop.TabIndex = 0;
			this.label_Hyperdesktop.Text = "Hyperdesktop2";
			this.label_Hyperdesktop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_motto
			// 
			this.label_motto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_motto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_motto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label_motto.Location = new System.Drawing.Point(12, 58);
			this.label_motto.Name = "label_motto";
			this.label_motto.Size = new System.Drawing.Size(378, 23);
			this.label_motto.TabIndex = 1;
			this.label_motto.Text = "Simple, fast screenshot sharing!";
			this.label_motto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_github
			// 
			this.btn_github.Location = new System.Drawing.Point(293, 93);
			this.btn_github.Name = "btn_github";
			this.btn_github.Size = new System.Drawing.Size(97, 26);
			this.btn_github.TabIndex = 2;
			this.btn_github.Text = "Github";
			this.btn_github.UseVisualStyleBackColor = true;
			this.btn_github.Click += new System.EventHandler(this.Btn_githubClick);
			// 
			// label_build
			// 
			this.label_build.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_build.Location = new System.Drawing.Point(12, 94);
			this.label_build.Name = "label_build";
			this.label_build.Size = new System.Drawing.Size(88, 26);
			this.label_build.TabIndex = 3;
			this.label_build.Text = "Build: 0";
			this.label_build.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_report
			// 
			this.btn_report.Location = new System.Drawing.Point(190, 94);
			this.btn_report.Name = "btn_report";
			this.btn_report.Size = new System.Drawing.Size(97, 26);
			this.btn_report.TabIndex = 4;
			this.btn_report.Text = "Report Issue";
			this.btn_report.UseVisualStyleBackColor = true;
			this.btn_report.Click += new System.EventHandler(this.Btn_reportClick);
			// 
			// frm_About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 126);
			this.Controls.Add(this.btn_report);
			this.Controls.Add(this.label_build);
			this.Controls.Add(this.btn_github);
			this.Controls.Add(this.label_motto);
			this.Controls.Add(this.label_Hyperdesktop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frm_About";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About Hyperdesktop2";
			this.Load += new System.EventHandler(this.Frm_AboutLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_build;
		private System.Windows.Forms.Button btn_report;
		private System.Windows.Forms.Label label_Hyperdesktop;
		private System.Windows.Forms.Label label_motto;
		private System.Windows.Forms.Button btn_github;
	}
}
