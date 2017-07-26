using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RadioScanner.NET
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
            if (!File.Exists(Environment.CurrentDirectory + "\\SQLite.Interop.dll"))
            {
                MessageBox.Show("Не найден файл SQLite.Interop.dll!", "Ошибка SQLite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
