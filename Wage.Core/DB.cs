using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace Wage.Core
{
    public class DB
    {
        private static SQLiteConnection m_conn = null;          // 当前帐套的数据库联接
        private static string m_db_filename = "";                 // 帐套的数据库名称（与年月对应，比如201310.db3表示2013年10月
                                                                //                   后缀名db3不用加）

        /// <summary>
        /// 创建新的数据库，不判断存在与否，直接创建
        /// </summary>
        /// <param name="filename">打开的文件名，不包括后缀名，如果有后缀名，会将后缀名略过</param>
        /// <returns> 成功返回真，不成功返回假。</returns>
        public static bool CreateDB(int year, int month)
        {
            bool done = true;       // 返回标记

            //保存原来的数据库名称，万一不成功，则还是打开原来的数据库
            string old_filename = "";

            // 如果当前的已经有打开的数据联接，则保存现场，再关闭
            if (m_conn != null)
            {
                old_filename = m_db_filename;
                m_conn.Close();
                m_conn.Dispose();
            }
            //SQLiteConnection conn = null;
            //string dbpath = "Data Source =" + Environment.CurrentDirectory + "/" + filename;

            //conn = new SQLiteConnection(dbpath);
            //conn.Open();
            //conn.Dispose();

            return done;
        }


        public static bool CloseDB(string filename)
        {
            return false;
        }

        /// <summary>
        /// 生成数据库文件名
        /// 最后变成"201304.gz"这样的格式
        /// </summary>
        /// <param name="year">帐套的年份</param>
        /// <param name="month">帐套的月份</param>
        /// <returns></returns>
        public static string GeneFilename(int year, int month)
        {
            return string.Format("{0:0000}", year) + string.Format("{0:00}", month) + ".gz";
        }
    }
}
