using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace hyperdesktop2
{
	
	public partial class frm_Edit : Form
	{
		List<Bitmap> undo;
		static Color pen_color = Color.Red;
		static Int16 pen_size = 5;
		Graphics g;
		Point point_1, point_2;
		Font font;
		Pen pen = new Pen(pen_color);
		SolidBrush brush = new SolidBrush(pen_color);
		Boolean using_pen = true;

        Dictionary<string, int> sizes = new Dictionary<string, int>();
		
		public Bitmap Result { set; get; }
		
		public frm_Edit(Bitmap _bmp, Font _font = null, Boolean _drop_shadow = false)
		{
			InitializeComponent();

            sizes.Add("Pixel", 1);
            sizes.Add("Small", 5);
            sizes.Add("Medium", 12);
            sizes.Add("Large", 24);
            sizes.Add("Huge", 32);
            sizes.Add("Massive", 64);

            foreach (KeyValuePair<string, int> pair in sizes)
                drop_size.Items.Add(pair.Key);

			undo = new List<Bitmap>();
			undo.Add(new Bitmap(_bmp));
			
			font = _font ?? new Font("Arial", 16) ;
			check_drop_shadow.Checked = _drop_shadow;
		}
		
		void Frm_EditLoad(object sender, EventArgs e)
		{
			// Set picture to the one we just recieved
			picture_box.SizeMode = PictureBoxSizeMode.AutoSize;
			picture_box.Image = new Bitmap(undo[0]);
            drop_color.Text = "Red";
			
			// Set control defaults
			drop_size.SelectedIndex = 1;
			drop_color.SelectedIndex = 1;
		}
		
		#region Controls
		void Btn_okayClick(object sender, EventArgs e)
		{
			Result = new Bitmap(picture_box.Image);
			this.Close();
			picture_box.Image = null;
			undo.Clear();
		}
		
		void Text_insertClick(object sender, EventArgs e)
		{
			if(text_insert.Text == "Insert Text")
				text_insert.Text = String.Empty;
		}
		
		void Btn_penClick(object sender, EventArgs e) { using_pen = true; }
		void Btn_insertClick(object sender, EventArgs e) {
			using_pen = false;
			Drop_sizeSelectedIndexChanged(sender, e);
		}
		
		void Drop_sizeSelectedIndexChanged(object sender, EventArgs e)
		{
			pen_size = Convert.ToInt16(sizes[drop_size.Text]);
			font = new Font("Arial", pen_size + 12);
		}
		
		void Drop_colorSelectedIndexChanged(object sender, EventArgs e)
		{
            pen_color = Color.FromName(drop_color.Text);
            brush = new SolidBrush(pen_color); 
		}
		#endregion
		
		#region Menu
		void UndoToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
				picture_box.Image = new Bitmap(undo[undo.Count - 2]);
				undo.RemoveAt(undo.Count - 1);
				GC.Collect();
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}
		
		void ResetToolStripMenuItemClick(object sender, EventArgs e)
		{
			picture_box.Image = new Bitmap(undo[0]);
		}
		
		void CopyToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			Clipboard.SetImage(picture_box.Image);
		}
		
		void Picture_boxMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			
			if(!using_pen) {
				g = Graphics.FromImage(picture_box.Image);
				
				if(check_drop_shadow.Checked)
					g.DrawString(text_insert.Text, font, new SolidBrush(Color.Black), point_2.X + 1, point_2.Y + 1);
			
				g.DrawString(text_insert.Text, font, brush, point_2.X, point_2.Y);
            }
			
			point_1 = e.Location;
			pen = new Pen(pen_color, pen_size);	
		}
		
		void SaveAsToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			var dialog = new SaveFileDialog();
			dialog.FileName = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
			dialog.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp|All Files (*.*)|*.*"; 
			
			if(dialog.ShowDialog() == DialogResult.OK) {
				picture_box.Image.Save(
					dialog.FileName,
					Global_Func.ext_to_imageformat(Path.GetExtension(dialog.FileName).Substring(1))
				);
			}			
		}
		#endregion
		
		#region Mouse Movements & Paint
		void Picture_boxMouseMove(object sender, MouseEventArgs e)
		{
			point_2 = e.Location;
			picture_box.Invalidate();
			
			if (!(e.Button == MouseButtons.Left && using_pen))
				return;
			
			// Actually drawing on the image
			try {
				g = Graphics.FromImage(picture_box.Image);
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.FillEllipse(
					new SolidBrush(pen_color),
					point_2.X - Convert.ToInt32(pen_size / 2),
					point_2.Y - Convert.ToInt32(pen_size / 2),
					pen_size, pen_size
				);
				g.DrawLine(pen, point_1, point_2);
        		point_1 = e.Location;
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}
		
		void Picture_boxMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			undo.Add(new Bitmap(picture_box.Image));
			
			if(undo.Count > 9)
				undo.RemoveAt(1);
			
			GC.Collect();
		}
		
		void Picture_boxPaint(object sender, PaintEventArgs e)
		{
			try {
				// Our hover preview
				if(using_pen)
					e.Graphics.FillEllipse(
						new SolidBrush(pen_color),
						point_2.X - Convert.ToInt32(pen_size / 2),
						point_2.Y - Convert.ToInt32(pen_size / 2),
						pen_size, pen_size
					);
				else {
					if(check_drop_shadow.Checked)
						e.Graphics.DrawString(text_insert.Text, font, new SolidBrush(Color.Black), point_2.X + 1, point_2.Y + 1);
					
					e.Graphics.DrawString(text_insert.Text, font, brush, point_2.X, point_2.Y);
				}
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}
		#endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys key)
        {
            if (key == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;

            return base.ProcessCmdKey(ref msg, key);
        }
	}
}
