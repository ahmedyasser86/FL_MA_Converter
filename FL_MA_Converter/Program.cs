using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            // BackUpDB();
        }

        private static void BackUpDB()
        {
            DateTime now = new DateTime();
            string path = @"C:\MonaseeqDB\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = Environment.CurrentDirectory + "\\myDB.mdf";
            path += now.ToShortDateString() + ".mdf";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.Copy(filepath, path);
        }
    }
}
