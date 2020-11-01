using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISM_GUI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (IsAdministrator() == false)
            {
                MessageBox.Show("Vous devez être administrateur pour utiliser DISM-GUI !!.", "Information DISM-GUI", MessageBoxButtons.OK);
                Application.Exit();
            }
            else Application.Run(new FormMain());
        }
        
        // Permet de savoir si l'application est ouvert en mode administrateur
        // Révision le 11/10/2020
        //
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
