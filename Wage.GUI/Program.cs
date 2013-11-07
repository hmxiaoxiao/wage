using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace Wage.GUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            string filename = "test.db3";
            SQLiteConnection conn = null;
            string dbpath = "Data Source =" + Environment.CurrentDirectory + "/" + filename;

            conn = new SQLiteConnection(dbpath);
            conn.Open();
        }
    }
}
