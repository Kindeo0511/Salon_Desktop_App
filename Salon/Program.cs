using Salon.View;
using System;
using System.Windows.Forms;

namespace Salon
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
            //Application.Run(new Form1());

            // Show splash screen
            //Form1 splash = new Form1();
            //splash.ShowDialog(); // blocks until closed

            // Then launch login form as main window
            Application.Run(new LoginForm());
            //Application.Run(new Form1());

        }
    }
}
