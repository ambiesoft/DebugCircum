using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;

namespace DebugCircumExe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Environment.CurrentDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            var start = new ProcessStartInfo();
            start.FileName = "dotnet";
            start.Arguments = "DebugCircum.dll";
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            start.UseShellExecute = false;

            try
            {
                var pro = Process.Start(start);
                pro.WaitForExit();
                if(pro.ExitCode != 0 )
                {
                    MessageBox.Show("Failed to launch 'dotnet DebugCircum.dll'. Please open a command prompt and run the command to see more information.",
                                        Application.ProductName,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(ex.Message);
                sb.AppendLine();
                sb.AppendLine(start.FileName);
                MessageBox.Show(ex.Message,
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
