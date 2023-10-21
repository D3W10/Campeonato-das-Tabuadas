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
            bool goBack = false;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            do
            {
                goBack = false;
                Welcome welcome = new Welcome();
                Application.Run(welcome);
                if (welcome.logInType == "Aprendiz")
                {
                    Dashboard dashboard = new Dashboard();
                    Application.Run(dashboard);
                    goBack = dashboard.goBack;
                }
                else if (welcome.logInType == "Mestre")
                {
                    MasterControl masterControl = new MasterControl();
                    Application.Run(masterControl);
                    goBack = masterControl.goBack;
                }
            }
            while (goBack == true);
        }
    }
}