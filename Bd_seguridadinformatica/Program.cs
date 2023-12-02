using Bd_seguridadinformatica.Diseños;
using Datos.Context;

namespace Bd_seguridadinformatica
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //var context = new SeguridadInformaticaContext();
            //context.Database.EnsureCreated();
            Application.Run(new Form1());
        }
    }
}