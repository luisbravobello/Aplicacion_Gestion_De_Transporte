using CapaPresentacion; // Aseg�rate de incluir el espacio de nombres correcto

namespace CapaPresentacion
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
            Application.Run(new vtnVentana()); // Aseg�rate de que vtnVentana est� correctamente referenciado
        }
    }
}