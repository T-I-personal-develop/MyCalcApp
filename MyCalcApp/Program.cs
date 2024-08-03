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

                // ��d�N�����`�F�b�N
                if (!createdNew)
                {
                    MyLog.Info($"�Q�d�N���������~ ");
                    return;
                }

                MyLog.Info($"{assemblyName}�J�n");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());

                MyLog.Info($"{assemblyName}�I��");
            }
            catch (Exception ex)
            {
                MyLog.Error($"�V�X�e���G���[: {ex.Message}, �ڍ�: {ex.StackTrace}");
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