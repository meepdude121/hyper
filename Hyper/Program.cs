using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hyper
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
            try
            {
                Application.Run(new Forms.Login());
            } catch (Exception)
            {
                MessageBox.Show("Incorrect login information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Delete(@".\login");
                Application.Restart();
            }
        }
    }
}