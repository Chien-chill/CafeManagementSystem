using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace Phan_Mem_Quan_Ly
{
    internal static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            string databaseFolder = Path.GetFullPath(Application.StartupPath + @"\..\..\Database");
            Debug.WriteLine("Database path: " + databaseFolder);
            AppDomain.CurrentDomain.SetData("DataDirectory", databaseFolder);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTrangChu());
        }
    }
}
