using Easy.Services.Interfaces.API;
using Easy.Services.Interfaces.PagamentoPedido;
using Easy.Services.Services.API;
using Easy.Services.Services.PedidoFormaPagamento;
using Microsoft.Extensions.DependencyInjection;

namespace Easy.Services.Services
{
    public static class AppServicos
    {
        private static ServiceCollection? serviceCollection;
        public static IApiService? IApiService { get; set; }
        public static IFormaPagamentoService? IFormaPagamentoService { get; set; }
        private static ServiceCollection ColecaoServico()
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IApiService, ApiService>();
            serviceCollection.AddSingleton<IFormaPagamentoService, FormaPagamentoService>();

            return serviceCollection;
        }
        public static void RequisicaoServicos()
        {
            ServiceProvider servicePriveder = ColecaoServico().BuildServiceProvider();

            IFormaPagamentoService = servicePriveder.GetRequiredService<IFormaPagamentoService>();
            IApiService = servicePriveder.GetRequiredService<IApiService>();

        }
    }
}
