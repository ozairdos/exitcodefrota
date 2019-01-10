using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
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

            //Application.Run(new FrmMenu());

            FrmLogin frmLogin = new FrmLogin();

            frmLogin.ShowDialog();

            if (frmLogin.logado)
            {
                Application.Run(new FrmMenu());
            }         
        }
    }
}
