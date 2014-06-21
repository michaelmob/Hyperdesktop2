using System;
using System.Runtime.InteropServices;
using System.Text;

namespace hyperdesktop2
{
	public static class Settings
	{
		// Unused
		public static Int32 build = 5;
		public static String build_url = "https://raw.githubusercontent.com/TheTarkus/Hyperdesktop2/master/BUILD";
		public static String release_url = "https://github.com/TheTarkus/Hyperdesktop2/releases";
		
		public static String app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Hyperdesktop2\";
		public static String exe_path = app_data + @"hyperdesktop2.exe";
		public static String ini_path = app_data + @"hyperdesktop2.ini";
		
		[DllImport("kernel32")]
	    static extern long WritePrivateProfileString(String section, String key, String val, String filePath);
		[DllImport("kernel32")]
	    static extern int GetPrivateProfileString(String section, String key, String def, StringBuilder retVal, Int32 size, String filePath);
	
	    public static String Write(String section, String key, String value)
	    {
	        WritePrivateProfileString(section, key, value, ini_path);
			return value;
	    }
	
	    public static String Read(String section, String key)
	    {
	        var temp = new StringBuilder(255);
	        int i = GetPrivateProfileString(section, key, "", temp, 255, ini_path);
	        return temp.ToString();
	    }
	
		public static String Exists(String section, String key, String value)
		{
			String str = Read(section, key);
			return (str.Length > 0) ? Read(section, key) : Write(section, key, value);
		}
		
		public static String settings_build;
		
		public static String imgur_client_id;
		
		public static Boolean save_screenshots;
		public static String save_folder;
		public static String save_format;
		public static Int16 save_quality;
		
		public static String upload_method;
		public static String upload_format;
		
		public static Boolean run_at_system_startup;
		public static Boolean copy_links_to_clipboard;
		public static Boolean show_cursor;
		public static Boolean sound_effects;
		public static Boolean balloon_messages;
		public static Boolean launch_browser;
		public static Boolean edit_screenshot;
		
		public static Boolean auto_detect_screen_res;
		public static String screen_res;
		
		public static void get_settings()
		{
			Global_Func.app_data_folder_create();
			settings_build			= Exists("hyperdesktop2", "build", Convert.ToString(build));
			
			imgur_client_id			= Exists("upload", "imgur_client_id", "84c55d06b4c9686");
				
			save_screenshots		= Global_Func.str_to_bool(Exists("general", "save_screenshots", "false"));
			save_folder				= Exists("general", "save_folder", Environment.CurrentDirectory + "\\captures\\");
			save_format 			= Exists("general", "save_format", "png");
			save_quality 			= Convert.ToInt16(Exists("general", "save_quality", "100"));
			
			upload_method 			= Exists("upload", "upload_method", "imgur");
			upload_format			= Exists("upload", "upload_format", "png");
			
			copy_links_to_clipboard = Global_Func.str_to_bool(Exists("behavior", "copy_links_to_clipboard", "true"));
			show_cursor 			= Global_Func.str_to_bool(Exists("behavior", "show_cursor", "false"));
			sound_effects 			= Global_Func.str_to_bool(Exists("behavior", "sound_effects", "true"));
			balloon_messages 		= Global_Func.str_to_bool(Exists("behavior", "balloon_messages", "true"));
			launch_browser 			= Global_Func.str_to_bool(Exists("behavior", "launch_browser", "false"));
			edit_screenshot 		= Global_Func.str_to_bool(Exists("behavior", "edit_screenshot", "true"));
			
			screen_res 				= Exists("screen", "screen_res", Snipper.reset_screen_bounds());
		}
		
		public static void write_settings()
		{
			Write("upload", 	"imgur_client_id", 			imgur_client_id);
			
			Write("general", 	"save_screenshots", 		save_screenshots.ToString());
			Write("general", 	"save_folder", 				save_folder);
			Write("general", 	"save_format", 				save_format);
			Write("general", 	"save_quality", 			save_quality.ToString());
			
			Write("behavior", 	"copy_links_to_clipboard", 	copy_links_to_clipboard.ToString());
			Write("behavior", 	"show_cursor", 				show_cursor.ToString());
			Write("behavior", 	"sound_effects", 			sound_effects.ToString());
			Write("behavior", 	"balloon_messages", 		balloon_messages.ToString());
			Write("behavior", 	"launch_browser", 			launch_browser.ToString());
			Write("behavior", 	"edit_screenshot", 			edit_screenshot.ToString());
			
			Write("screen", 	"screen_res",			 	screen_res);
		}
		
	}
}
