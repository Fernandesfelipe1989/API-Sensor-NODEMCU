using System;
using System.Windows.Forms;

namespace PI_RFID_Arduino_WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fConnect());
        }
    }
}
