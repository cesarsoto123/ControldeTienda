using QuestPDF.Infrastructure;
using System;
using System.Windows.Forms;

namespace Tienda
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CajaRegistradoraForm());
        }
    }
}
