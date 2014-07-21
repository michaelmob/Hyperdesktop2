using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace hyperdesktop2
{
    class Screen_Bounds
    {
        public static Rectangle bounds;

        public static void load()
        {
            String[] bounds_arr = Settings.screen_res.Split(',');
            bounds = new Rectangle(
                Convert.ToInt32(bounds_arr[0]),
                Convert.ToInt32(bounds_arr[1]),
                Convert.ToInt32(bounds_arr[2]),
                Convert.ToInt32(bounds_arr[3])
            );
        }
        public static String reset()
        {
            var screen_bounds_temp = new Rectangle(0, 0, 0, 0);

            foreach (var screen in Screen.AllScreens)
                if (screen != Screen.PrimaryScreen)
                    screen_bounds_temp = Rectangle.Union(screen.Bounds, screen_bounds_temp);

            return String.Format(
                "{0},{1},{2},{3}",
                screen_bounds_temp.Left,
                screen_bounds_temp.Top,
                SystemInformation.VirtualScreen.Width,
                SystemInformation.VirtualScreen.Height
            );
        }
    }
}
