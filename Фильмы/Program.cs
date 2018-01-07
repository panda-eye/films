using System;
using System.Windows.Forms;

namespace Фильмы
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new StartProgram());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.ToString());
            }
        }
    }
}
