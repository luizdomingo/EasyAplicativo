using Easy.Services.Dtos;
using Easy.Services.Dtos.PedidoFormaPagamento;
using Easy.Services.Interfaces.API;
using Easy.Services.Interfaces.PagamentoPedido;
using Easy.Services.Shared;
using System.Collections.Generic;
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
                string fullUrl = $"{Globais.UrlApiBase}/api/PedidosFormasPagamentos/forma-pagamento";
                string result = await _services.Get(fullUrl);
                ResponseDto<List<FormaPagamentoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<FormaPagamentoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<FormaPagamentoDto>> resposta = new ResponseDto<List<FormaPagamentoDto>>();
                resposta.Status = false;
                resposta.Mensagem = $"Erro interno do sistema.Detalhes:  {ex.Message}";
                return resposta;
            }
        }

        public async Task<ResponseDto<List<FormaPagamentoDto>>> GetById(Guid id)
        {
            try
            {
                string fullUrl = $"{Globais.UrlApiBase}/api/PedidosFormasPagamentos/forma-pagamento/{id}/id";
                string result = await _services.Get(fullUrl); ResponseDto<List<FormaPagamentoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<FormaPagamentoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<FormaPagamentoDto>> resposta = new ResponseDto<List<FormaPagamentoDto>>();
                resposta.Status = false;
                resposta.Mensagem = $"Erro interno do sistema.Detalhes:  {ex.Message}";
                return resposta;
            }
        }
        public async Task<ResponseDto<List<FormaPagamentoDto>>> Create(FormaPagamentoDtoCreate formaPagamentoDtoCreate)
        {
            try
            {
                string fullUrl = $"{Globais.UrlApiBase}/api/PedidosFormasPagamentos/forma-pagamento/create";
                string result = await AppServicos.IApiService.Post(fullUrl, formaPagamentoDtoCreate);
                ResponseDto<List<FormaPagamentoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<FormaPagamentoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<FormaPagamentoDto>> resposta = new ResponseDto<List<FormaPagamentoDto>>();
                resposta.Status = false;
                resposta.Mensagem = $"Erro interno do sistema.Detalhes:  {ex.Message}";
                return resposta;
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
