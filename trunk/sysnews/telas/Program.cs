using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace telas
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            System.Threading.Thread.CurrentThread.CurrentCulture =  new System.Globalization.CultureInfo("pt-BR");

            // The following line provides localization for the application's user interface. 
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
            Application.Run(new frmLogin());
            //Application.Run(new telas.estoque.frmBase());
        }
    }
}
