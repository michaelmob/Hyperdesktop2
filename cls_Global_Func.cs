using System;
using System.IO;
using System.Media;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Microsoft.Win32;

namespace hyperdesktop2
{
	public static class Global_Func
	{
		public static ImageFormat ext_to_imageformat(String ext)
		{
			switch(ext.ToLower()) {
				case "jpeg":
				case "jpg":
					return ImageFormat.Jpeg;
				case "png":
					return ImageFormat.Png;
				default:
					return ImageFormat.Bmp;
			}
		}
		
		public static Boolean str_to_bool(String str)
		{
			return str.ToLower() == "true";
		}
		
		public static String get_text_inbetween(String input, String a, String b)
		{
			return input.Substring(input.IndexOf(a) + a.Length, input.IndexOf(b) - input.IndexOf(a) - a.Length);
		}
		
		public static String bmp_to_base64(Bitmap bmp, ImageFormat format)
		{
			using (var stream = new MemoryStream())
			{
				bmp.Save(stream, format);
				Byte[] bytes = stream.ToArray();
				
				return Convert.ToBase64String(bytes);
			}
		}
		
		readonly public static RegistryKey reg_key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
		
		public static void run_at_startup(Boolean run)
		{
			if(run)
				reg_key.SetValue("Hyperdesktop2", Application.ExecutablePath.ToString());
			else
				reg_key.DeleteValue("Hyperdesktop2", false);
		}
		
		public static void play_sound(String file)
		{
			if(Settings.sound_effects)
				using (var sound_player = new SoundPlayer(file))
	        		sound_player.Play();
		}
	}
}
