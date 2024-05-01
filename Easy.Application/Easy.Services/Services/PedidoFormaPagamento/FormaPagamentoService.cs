using Easy.Services.Dtos;
using Easy.Services.Dtos.PedidoFormaPagamento;
using Easy.Services.Interfaces.API;
using Easy.Services.Interfaces.PagamentoPedido;
using Easy.Services.Shared;
using System.Text.Json;

namespace Easy.Services.Services.PedidoFormaPagamento
{
    public class FormaPagamentoService : IFormaPagamentoService
    {
        private readonly IApiService? _services;
        private readonly JsonSerializerOptions _options;

        public FormaPagamentoService(IApiService? services)
        {
            _services = services;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            _options = options;
        }

        public async Task<ResponseDto<List<FormaPagamentoDto>>> GetAll()
        {
            try
            {

                var fullUrl = $"{Globais.urlBaseAPI}/api/PedidosFormasPagamentos/forma-pagamento";
                var result = await _services.Get(fullUrl); 
                var resposta = JsonSerializer.Deserialize<ResponseDto<List<FormaPagamentoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ResponseDto<List<FormaPagamentoDto>>> GetById(Guid id)
        {
            try
            {
                var fullUrl = $"{Globais.urlBaseAPI}/api/PedidosFormasPagamentos/forma-pagamento/{id}/id";
                var result = await _services.Get(fullUrl); var resposta = JsonSerializer.Deserialize<ResponseDto<List<FormaPagamentoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<ResponseDto<List<FormaPagamentoDto>>> Create(FormaPagamentoDtoCreate formaPagamentoDtoCreate)
        {
            try
            {
                var fullUrl = $"{Globais.urlBaseAPI}/api/PedidosFormasPagamentos/forma-pagamento/create";
                var result = await AppServicos.IApiService.Post(fullUrl, formaPagamentoDtoCreate);
                var resposta = JsonSerializer.Deserialize<ResponseDto<List<FormaPagamentoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Task<ResponseDto<List<FormaPagamentoDto>>> Update(FormaPagamentoDtoUpdate formaPagamentoDtoUpdate)
        {
            throw new NotImplementedException();
        }
        public Task<ResponseDto<List<FormaPagamentoDto>>> DesabilitarHabilitar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
