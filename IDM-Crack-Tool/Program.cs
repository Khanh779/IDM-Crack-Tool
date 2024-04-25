using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDM_Crack_Tool
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(Process_IDM.IsAdministrator() == false)
            {
                if (MessageBox.Show("Please run this program as administrator!\nDo you want to continue?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.No)
                return;
                Process_IDM.EnsureAdminRights();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
