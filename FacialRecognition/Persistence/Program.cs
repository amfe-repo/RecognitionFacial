using Persistence.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistence.WinForms;

namespace Persistence
{
    internal static class Program
    {
        public static string state = null; 
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            if(state == "Admin")
                Application.Run(new Administration());
            if (state == "Scan")
                Application.Run(new ScamForm());
        }
    }
}
