using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_MA_Converter
{
    public static class Program
    {

        public static MainForm frm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBCommands.OpenConn();

            frm = new MainForm();

            Application.Run(frm);

            DBCommands.CloseConn();
        }
    }
}
