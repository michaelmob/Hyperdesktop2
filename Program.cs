using System;
using System.Threading;
using System.Windows.Forms;

namespace hyperdesktop2
{
	internal sealed class Program
	{
		static Mutex mutex;
		
		static Boolean Single_Instance()
	    {
			try
			{
			    Mutex.OpenExisting("Hyperdesktop2");
			}
			catch
			{
			    Program.mutex = new Mutex(true, "Hyperdesktop2");
			    return true;
			}
			return false;
    	}
		
		[STAThread]
		private static void Main(string[] args)
		{
			if(!Program.Single_Instance()) {
				MessageBox.Show("Hyperdesktop2 is already running!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frm_Main());
		}
		
	}
}
