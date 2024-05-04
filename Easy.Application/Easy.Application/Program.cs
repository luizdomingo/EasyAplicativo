using Easy.Application.Forms.Login;
using Easy.Services.Shared;

namespace Easy.Application
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

            string url = Properties.Settings.Default.UrlApiBase;
            Globais.SetUrlApiBase(url);

            AppServicos.RequisicaoServicos();


            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }
    }
}