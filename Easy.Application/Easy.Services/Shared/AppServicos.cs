using Easy.Services.Interfaces.Account;
using Easy.Services.Interfaces.API;
using Easy.Services.Interfaces.PagamentoPedido;
using Easy.Services.Services.Account;
using Easy.Services.Services.API;
using Easy.Services.Services.PedidoFormaPagamento;
using Microsoft.Extensions.DependencyInjection;

namespace Easy.Services.Shared
{
    public static class AppServicos
    {
        private static ServiceCollection? serviceCollection;
        public static IApiService? IApiService { get; set; }
        public static IFormaPagamentoService? IFormaPagamentoService { get; set; }

        public static IIdentityService? IIdentityService { get; set; }
        private static ServiceCollection ColecaoServico()
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IApiService, ApiService>();
            serviceCollection.AddSingleton<IFormaPagamentoService, FormaPagamentoService>();
            serviceCollection.AddSingleton<IIdentityService, IdentityService>();

            return serviceCollection;
        }
        public static void RequisicaoServicos()
        {
            ServiceProvider serviceProvider = ColecaoServico().BuildServiceProvider();

            IFormaPagamentoService = serviceProvider.GetRequiredService<IFormaPagamentoService>();
            IApiService = serviceProvider.GetRequiredService<IApiService>();
            IIdentityService = serviceProvider.GetRequiredService<IIdentityService>();
        }
    }
}
