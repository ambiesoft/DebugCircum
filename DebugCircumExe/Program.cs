using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using Ambiesoft;
using System.Xml;

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
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            int retval = -1;
            string output, err;
            try
            {
                AmbLib.OpenCommandGetResult(
                                start,
                                out retval,
                                out output,
                                out err);
                if (retval != 0 )
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Failed to launch 'dotnet DebugCircum.dll.'");
                    sb.AppendLine();
                    sb.AppendLine("The standard output of the command:");
                    sb.AppendLine(output);
                    sb.AppendLine();
                    sb.AppendLine("The standard error of the command:");
                    sb.AppendLine(err);
                    MessageBox.Show(AmbLib.ReplaceTripleReturn(sb.ToString()),
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
                MessageBox.Show(AmbLib.ReplaceTripleReturn(sb.ToString()),
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
