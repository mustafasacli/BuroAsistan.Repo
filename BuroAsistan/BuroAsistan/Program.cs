using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuroAsistan
{
    static class Program
    {
        public static bool isLogin = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BuroAsistan.View.Login.FrmLogin());
            if (isLogin)
            {
                Application.Run(new BuroAsistan.View.Buro.FrmMain());
            }
        }
    }
}
