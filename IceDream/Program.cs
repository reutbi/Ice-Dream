using System;
using System.Windows.Forms;

namespace IceDream
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            welcomeForm welcome = new welcomeForm();
            welcome.ShowDialog();
            Application.Run(new MainMenuForm());
        }
    }
}
