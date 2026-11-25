using MOHASEB.Views.GUIs.AccountsManagement;
using MOHASEB.Views.GUIs.Main;
using MOHASEB.Views.GUIs.MOHASEBMain.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB
{
    internal static class Program
    {
         ///
         // Ctrl M Ctrl P expand methodes
         // Ctrl M Ctrl O Collaps methodes
         ///


                /// <summary>
                /// The main entry point for the application.
                /// </summary>
                [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Main());
        }
    }
}
