using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassMailer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();

            FixWebView2();
            CoreWebView2Environment.SetLoaderDllFolderPath(Path.GetTempPath());

            new FontsLoader();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
        private static void FixWebView2()
        {
            string path = Path.Combine(Path.GetTempPath(), "WebView2Loader.dll");
            if (!File.Exists(path))
            {
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MassMailer.WebView2Loader.dll");
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    stream.CopyTo(fileStream);
                }
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
