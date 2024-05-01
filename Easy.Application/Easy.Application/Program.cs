using Easy.Application.Forms.PedidoFormaPagamento;
using Easy.Services.Services;

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
           
            
            AppServicos.RequisicaoServicos();
            FrmFormaPagamento frm = new FrmFormaPagamento();
            frm.ShowDialog();
        }
    }
}