using Easy.Services.Interfaces.Account;
using Easy.Services.Interfaces.API;
using Easy.Services.Interfaces.PagamentoPedido;
using Easy.Services.Interfaces.ProdutoCategoria;
using Easy.Services.Services.Account;
using Easy.Services.Services.API;
using Easy.Services.Services.PedidoFormaPagamento;
using Easy.Services.Services.ProdutoCategoria;
using Microsoft.Extensions.DependencyInjection;

namespace Easy.Services.Shared
{
    public static class AppServicos
    {
        private static ServiceCollection? serviceCollection;

        public static IApiService? IApiService { get; set; }
        public static IIdentityService? IIdentityService { get; set; }
        public static IFormaPagamentoService? IFormaPagamentoService { get; set; }
        public static ICategoriaProdutoService? ICategoriaProdutoService { get; set; }


        private static ServiceCollection ColecaoServico()
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IApiService, ApiService>();
            serviceCollection.AddSingleton<IIdentityService, IdentityService>();
            serviceCollection.AddSingleton<IFormaPagamentoService, FormaPagamentoService>();
            serviceCollection.AddSingleton<ICategoriaProdutoService, CategoriaProdutoService>();

            return serviceCollection;
        }
        public static void RequisicaoServicos()
        {
            ServiceProvider serviceProvider = ColecaoServico().BuildServiceProvider();

            IApiService = serviceProvider.GetRequiredService<IApiService>();
            IIdentityService = serviceProvider.GetRequiredService<IIdentityService>();
            IFormaPagamentoService = serviceProvider.GetRequiredService<IFormaPagamentoService>();
            ICategoriaProdutoService = serviceProvider.GetRequiredService<ICategoriaProdutoService>();
        }
    }
}
