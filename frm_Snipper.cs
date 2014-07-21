using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace hyperdesktop2
{
    public partial class frm_Snipper : Form
    {

        public static Rectangle get_region()
        {
            var snipper = new frm_Snipper();

            if (snipper.ShowDialog() == DialogResult.OK)
                return snipper.rect;

            return new Rectangle(0, 0, 0, 0);
        }

        public frm_Snipper()
        {
            InitializeComponent();

            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Cursor = Cursors.Cross;

            this.TransparencyKey = Color.White;
            this.BackColor = Color.White;
            this.Opacity = 0.70;

            this.Location = new Point(Screen_Bounds.bounds.Left, Screen_Bounds.bounds.Top);
            this.Size = new Size(Screen_Bounds.bounds.Width, Screen_Bounds.bounds.Height);
        }

        public Rectangle rect { get; set; }

        private Rectangle select = new Rectangle();
        private Rectangle previous_select = new Rectangle();
        private Point start;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            start = e.Location;
            select = new Rectangle(e.Location, new Size(0, 0));
            this.Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            int x1 = Math.Min(e.X, start.X);
            int y1 = Math.Min(e.Y, start.Y);
            int x2 = Math.Max(e.X, start.X);
            int y2 = Math.Max(e.Y, start.Y);

            Invalidate(previous_select);
            previous_select = select;

            select = new Rectangle(x1, y1, x2 - x1, y2 - y1);
            Invalidate(select);

            // Invalidating the whole created the delay 
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (select.Width <= 0 || select.Height <= 0)
                return;

            rect = new Rectangle(
                Screen_Bounds.bounds.Left + select.Left,
                Screen_Bounds.bounds.Top + select.Top,
                select.Width,
                select.Height
            );

            DialogResult = DialogResult.OK;
        }

        Brush brush = new SolidBrush(Color.Black);
        Pen pen = new Pen(Color.Red);

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Region region = new Region(new Rectangle(0, 0, this.Width, this.Height)))
            {
                region.Exclude(select);
                region.Intersect(e.ClipRectangle);
                e.Graphics.FillRegion(brush, region);
                e.Graphics.DrawRectangle(pen, select.X, select.Y, select.Width - 1, select.Height - 1);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys key)
        {
            if (key == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;

            return base.ProcessCmdKey(ref msg, key);
        }
    }
}