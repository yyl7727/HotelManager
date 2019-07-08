using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HotelMain.Tool
{
    /// <summary>
    /// 日志类
    /// </summary>
    public static class LogHelper
    {
        /// <summary>
        /// 时间用于存放按月分组的日志的文件夹命名
        /// </summary>
        private static string dateTimeNow = DateTime.Now.ToString("yyyyMM");
        /// <summary>
        ///  路径(应用程序根目录)
        /// </summary>
        private static string path = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// 写调用数据库的记录
        /// </summary>
        public static void writeSqlLog(string sql)
        {
            //组装日志所在路径
            StringBuilder sbLogPath = new StringBuilder();
            sbLogPath.Append(path);
            sbLogPath.Append("Log\\");
            sbLogPath.Append(dateTimeNow);
            //组装日志内容
            StringBuilder sbLogInfo = new StringBuilder();
            sbLogInfo.Append(DateTime.Now.ToString());
            sbLogInfo.Append(string.Format("   :   {0}",sql));
            //日志按月分类，如果新的一个月，建立一个新的文件夹存放
            if (!Directory.Exists(sbLogPath.ToString()))
            {
                //创建文件夹
                DirectoryInfo directoryInfo = new DirectoryInfo(sbLogPath.ToString());
                directoryInfo.Create();
                //路径详细至文件
                sbLogPath.Append(string.Format("\\{0}.txt", DateTime.Now.ToString("yyyyMMdd")));
                //没有则创建这个文件
                FileStream fsWriteLog = new FileStream(sbLogPath.ToString(), FileMode.Create, FileAccess.Write);              
                StreamWriter swWriteLog = new StreamWriter(fsWriteLog);
                swWriteLog.WriteLine(sbLogInfo.ToString());
                swWriteLog.Close();
                fsWriteLog.Close();
            }
            else
            {
                sbLogPath.Append(string.Format("\\{0}.txt", DateTime.Now.ToString("yyyyMMdd")));
                FileStream fs = new FileStream(sbLogPath.ToString(), FileMode.Append, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(sbLogInfo.ToString());
                sr.Close();
                fs.Close();
            }
        }
    }
}
