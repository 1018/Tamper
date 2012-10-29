using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SystemCommon
{
    public class Logger
    {
        /// <summary>
        /// ログ書き込み
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteLog(string msg, string logDirPath)
        {
            DateTime dt = DateTime.Now;
            StreamWriter sw = new StreamWriter(
                logDirPath + @"\" + dt.ToString("yyyyMMdd") + ".log",
                true,
                Encoding.GetEncoding(932));

            sw.WriteLine(dt.ToString("MM月dd日 HH:mm:ss.fff") + " " + msg);

            sw.Dispose();
           
        }

 

        /// <summary>
        /// 実行ファイルのパス取得
        /// </summary>
        /// <returns></returns>
        private static string getExeAppPath()
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetEntryAssembly();
            if (asm == null)
                return "";
            else
                return System.IO.Path.GetDirectoryName(asm.Location);
        }
    }
}
