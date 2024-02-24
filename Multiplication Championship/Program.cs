using System;
using System.Windows.Forms;

namespace Multiplication_Championship
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            bool goBack;

            do
            {
                goBack = false;
                Welcome welcome = new();
                Application.Run(welcome);
                if (welcome.logInType == "Apprentice")
                {
                    Dashboard dashboard = new();
                    Application.Run(dashboard);
                    goBack = dashboard.goBack;
                }
                else if (welcome.logInType == "Master")
                {
                    MasterControl masterControl = new();
                    Application.Run(masterControl);
                    goBack = masterControl.goBack;
                }
            }
            while (goBack == true);
        }
    }
}