using Salon.Controller;
using Salon.Repository;
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
            //Application.Run(new LoginForm());


            //Application.Run(new Form1());


            //Application.Run(new ConfigureSettingsForm());

            var repo = new UserRepository();
            var controller = new UserController(repo);





            if (!controller.IsUserAccountExists())
            {

                Application.Run(new ConfigureSettingsForm());


            }
            else
            {
                Application.Run(new LoginForm());

            }

        }
    }

}
    

