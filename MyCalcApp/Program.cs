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

                // ��d�N�����`�F�b�N
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
                // �~���[�e�b�N�X���擾����Ă���ꍇ�ɂ̂݃����[�X
                if (createdNew)
                {
                    mutex.ReleaseMutex();
                }
            }
        }

    }
}