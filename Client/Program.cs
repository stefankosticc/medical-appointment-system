using Client.Forms;
using Client.Session;

namespace Client
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
            Koordinator.Instance.OtvoriLoginFormu();
            if (Koordinator.Instance.UlogovanZaposleni != null)
            {
                Application.Run(Koordinator.Instance.FrmGlavna);
            }
        }
    }
}