using Microsoft.VisualBasic.Logging;
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

                // 二重起動をチェック
                if (!createdNew)
                {
                    return;
                }


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());

            }
            catch (Exception ex)
            {
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