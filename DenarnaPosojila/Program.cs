using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DenarnaPosojila.Forms;
using System.IO;

namespace DenarnaPosojila
{
    static class Program
    {
        public static long? IDUporabnika = null;  
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var frm = new LoginForm();
            frm.ControlBox = false;
            frm.ShowInTaskbar = false;
            Application.Run(frm);
            if (frm.LogonSuccessfull)
            {
                Application.Run(new Main());
            }
            else { return; }
            if (frm.Relogin) {
                frm.Relogin = false;
                Application.Run(frm);
            }
        }
    }
}
