using Citicon.Forms;
using Citicon.GSM;
using System;
using System.Windows.Forms;

namespace Citicon.PayrollApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SMS.ReadMessage();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(new MainForm()));
        }
    }
}
