using System;
using System.Drawing;
using System.Windows.Forms;

public static class Snipper
{
	static Rectangle screen_bounds;
	static Rectangle temp_rect_1, temp_rect_2;
	static Point pt_start_1, pt_end_1;
	static Point pt_start_2, pt_end_2;
	static Form region_form = new Form();
	static Color rectangle_color = Color.White;
	static Color back_color = Color.Black;
	const Double opacity = 0.60;
	
	public static void initialize()
	{
		foreach (var screen in Screen.AllScreens)
			if (screen != Screen.PrimaryScreen)
				screen_bounds = Rectangle.Union(screen.Bounds, screen_bounds);
		
		// Set the design properties
		region_form.FormBorderStyle = FormBorderStyle.None;
		region_form.TopMost = true;
		region_form.Opacity = opacity;
		region_form.TransparencyKey = rectangle_color;
		region_form.BackColor = back_color;
		region_form.Cursor = Cursors.Cross;
		region_form.ShowInTaskbar = false;
		
		// Since we can't set DoubleBuffer to true because of it's protection
		// we'll just use reflection to set it
		typeof(Control).GetProperty(
			"DoubleBuffered", 
			System.Reflection.BindingFlags.NonPublic | 
			System.Reflection.BindingFlags.Instance
		).SetValue(region_form, true, null);
		
		region_form.Top = screen_bounds.Top;
		region_form.Left = screen_bounds.Left;
		region_form.Width = screen_bounds.Width;
		region_form.Height = screen_bounds.Height;
		region_form.StartPosition = FormStartPosition.Manual;
		
		// Here we setup the methods region_form
		// will use when it is activated
		region_form.Paint += snipper_paint;
		region_form.MouseDown += snipper_mouse_down;
		region_form.MouseUp += snipper_mouse_up;
		region_form.MouseMove += snipper_mouse_move;
	}

	public static Rectangle get_region()
	{
		temp_rect_1 = new Rectangle(0, 0, 0, 0);
		region_form.ShowDialog();
		return temp_rect_2;
	}
	
	static void snipper_mouse_down(object sender, MouseEventArgs e)
	{
		pt_start_1	= e.Location;
		pt_end_1	= pt_start_1;
		
		pt_start_2  = Cursor.Position;
		pt_end_2	= pt_start_2;
		
		temp_rect_1 = new Rectangle(e.X, e.Y, 0, 0);
		region_form.Invalidate();
	}
	
	static void snipper_mouse_move(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left)
			return;
		
		pt_start_1 = e.Location;
		pt_start_2 = Cursor.Position;
		
		temp_rect_1 = new Rectangle(
			Math.Min(pt_start_1.X,  pt_end_1.X),
			Math.Min(pt_start_1.Y,  pt_end_1.Y),
			Math.Abs(pt_start_1.X - pt_end_1.X),
			Math.Abs(pt_start_1.Y - pt_end_1.Y)
		);
		
		temp_rect_2 = new Rectangle(
			Math.Min(pt_start_2.X,  pt_end_2.X),
			Math.Min(pt_start_2.Y,  pt_end_2.Y),
			Math.Abs(pt_start_2.X - pt_end_2.X),
			Math.Abs(pt_start_2.Y - pt_end_2.Y)
		);
		
		region_form.Invalidate();
	}
	
	static void snipper_mouse_up(object sender, MouseEventArgs e)
	{
		region_form.Close();
	}
			
	static void snipper_paint(object sender, PaintEventArgs e)
	{		
		e.Graphics.FillRectangle(new SolidBrush(rectangle_color), temp_rect_1);
	} 
}