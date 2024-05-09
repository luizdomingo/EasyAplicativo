using Easy.Services.Dtos;
using Easy.Services.Dtos.PedidoFormaPagamento;
using Easy.Services.Dtos.PedidoSituacao;
using Easy.Services.Interfaces.API;
using Easy.Services.Interfaces.PedidoSituacao;
using Easy.Services.Shared;
using System.Text.Json;

namespace Easy.Services.Services.PedidoSituacao
{
    public class SituacaoPedidoService : ISituacaoPedidoService
    {
        private readonly IApiService? _services;
        private readonly JsonSerializerOptions _options;

        public SituacaoPedidoService(IApiService? services)
        {
            _services = services;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            _options = options;
        }

        public async Task<ResponseDto<List<SituacaoPedidoDto>>> GetAll()
        {
            try
            {
                string fullUrl = $"{Globais.UrlApiBase}/api/PedidosSituacao/situacao-pedido";
                string result = await _services.Get(fullUrl);
                ResponseDto<List<SituacaoPedidoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<SituacaoPedidoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<SituacaoPedidoDto>> resposta = new ResponseDto<List<SituacaoPedidoDto>>();
                resposta.Status = false;
                resposta.Mensagem = $"Erro interno do sistema.Detalhes:  {ex.Message}";
                return resposta;
            }
        }
        public async Task<ResponseDto<List<SituacaoPedidoDto>>> Get(Guid id)
        {
            try
            {
                string fullUrl = $"{Globais.UrlApiBase}/api/PedidosSituacao/situacao-pedido/{id}/id";
                string result = await _services.Get(fullUrl);
                ResponseDto<List<SituacaoPedidoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<SituacaoPedidoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<SituacaoPedidoDto>> resposta = new ResponseDto<List<SituacaoPedidoDto>>();
                resposta.Status = false;
                resposta.Mensagem = $"Erro interno do sistema.Detalhes:  {ex.Message}";
                return resposta;
            }
        }
        public async Task<ResponseDto<List<SituacaoPedidoDto>>> Get(string descricao)
        {
            try
            {
                string fullUrl = $"{Globais.UrlApiBase}/api/PedidosSituacao/situacao-pedido/{descricao}/descricao";
                string result = await _services.Get(fullUrl);
                ResponseDto<List<SituacaoPedidoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<SituacaoPedidoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<SituacaoPedidoDto>> resposta = new ResponseDto<List<SituacaoPedidoDto>>();
                resposta.Status = false;
                resposta.Mensagem = $"Erro interno do sistema.Detalhes:  {ex.Message}";
                return resposta;
            }
        }
        public async Task<ResponseDto<List<SituacaoPedidoDto>>> Create(SituacaoPedidoDtoCreate create)
        {
            try
            {
                string fullUrl = $"{Globais.UrlApiBase}/api/PedidosSituacao/situacao-pedido/create";
                string result = await _services.Post(fullUrl, create);
                ResponseDto<List<SituacaoPedidoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<SituacaoPedidoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<SituacaoPedidoDto>> resposta = new ResponseDto<List<SituacaoPedidoDto>>();
                resposta.Status = false;
                resposta.Mensagem = $"Erro interno do sistema.Detalhes:  {ex.Message}";
                return resposta;
            }
        }
        public async Task<ResponseDto<List<SituacaoPedidoDto>>> Desabilitar(Guid id)
        {
            try
            {
                string fullUrl = $"{Globais.UrlApiBase}/api/PedidosSituacao/situacao-pedido/{id}/desabilitar";
                string result = await _services.Post(fullUrl, null);
                ResponseDto<List<SituacaoPedidoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<SituacaoPedidoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<SituacaoPedidoDto>> resposta = new ResponseDto<List<SituacaoPedidoDto>>();
                resposta.Status = false;
                resposta.Mensagem = $"Erro interno do sistema.Detalhes:  {ex.Message}";
                return resposta;
            }
        }
        public async Task<ResponseDto<List<SituacaoPedidoDto>>> Update(SituacaoPedidoDtoUpdate update)
        {
            try
            {
                string fullUrl = $"{Globais.UrlApiBase}/api/PedidosSituacao/situacao-pedido/update";
                string result = await _services.Put(fullUrl, update);
                ResponseDto<List<SituacaoPedidoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<SituacaoPedidoDto>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<SituacaoPedidoDto>> resposta = new ResponseDto<List<SituacaoPedidoDto>>();
                resposta.Status = false;
                resposta.Mensagem = $"Erro interno do sistema.Detalhes:  {ex.Message}";
                return resposta;
            }
        }
    }
}
