using MyCalcApp.Libraries;
using System.Reflection;

namespace MyCalcApp
{
    internal static class Program
    {
        private static Mutex? mutex;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            bool createdNew;
            mutex = new Mutex(true, assemblyName, out createdNew);

            try
            {
                MyLog.StartMyLog();

                // 二重起動をチェック
                if (!createdNew)
                {
                    MyLog.Info($"２重起動処理中止 ");
                    return;
                }

                MyLog.Info($"{assemblyName}開始");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());

                MyLog.Info($"{assemblyName}終了");
            }
            catch (Exception ex)
            {
                MyLog.Error($"システムエラー: {ex.Message}, 詳細: {ex.StackTrace}");
            }
            finally
            {
                // ミューテックスが取得されている場合にのみリリース
                if (createdNew)
                {
                    mutex.ReleaseMutex();
                }
            }
        }

    }
}