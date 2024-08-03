using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using log4net.Repository;
using System;
using System.IO;
using System.Text;

namespace MyCalcApp.Libraries
{

#warning Log4Netを使用していません。   

    /// <summary>
    /// Log出力クラス
    /// </summary>
    public class MyLog
    {
        private static string logFilePath = "";
        private readonly object lockObject = new object();

        public static void StartMyLog()
        {
            string exeDirectory = AppContext.BaseDirectory;
            logFilePath = Path.Combine(exeDirectory, "log.txt");

#if !DEBUG
            // 初回ログファイルの作成
            Common.WriteEmptyFile(logFilePath, Encoding.UTF8);
#endif
        }

        public static void Info(string message)
        {
            try
            {
                string Logpattern = $"{System.DateTime.Now.ToString()} :Info: {message}";

#if DEBUG
                System.Diagnostics.Debug.WriteLine(Logpattern);
#else
                Common.WriteTxt(logFilePath, Logpattern, true, Encoding.UTF8);
#endif
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public static void Error(string message)
        {
            try
            {
                string Logpattern = $"{System.DateTime.Now.ToString()} :Error: {message}";

#if DEBUG
                System.Diagnostics.Debug.WriteLine(Logpattern);
#else

                Common.WriteTxt(logFilePath, Logpattern, true, Encoding.UTF8);

#endif
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }

}
