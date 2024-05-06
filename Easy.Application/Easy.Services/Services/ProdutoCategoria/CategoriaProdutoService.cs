using Easy.Services.Dtos;
using Easy.Services.Dtos.ProdutoCategoria;
using Easy.Services.Interfaces.API;
using Easy.Services.Interfaces.ProdutoCategoria;
using Easy.Services.Shared;
using System.Text.Json;

namespace Easy.Services.Services.ProdutoCategoria
{
    public class CategoriaProdutoService : ICategoriaProdutoService
    {
        private readonly IApiService? _service;
        private readonly JsonSerializerOptions _options;
        private string _urlBase = string.Empty;

        public CategoriaProdutoService(IApiService? services)
        {
            _urlBase = Globais.UrlApiBase;
            _service = services;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            _options = options;
        }
        public async Task<ResponseDto<List<CategoriaProdutoDto>>> Get()
        {
            try
            {
                string fullUrl = $"{_urlBase}/api/ProdutosCategorias/categorias";
                string result = await _service!.Get(fullUrl);

                ResponseDto<List<CategoriaProdutoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<CategoriaProdutoDto>>>(result, _options);

                return resposta!;
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> resposta = new ResponseDto<List<CategoriaProdutoDto>>();
                resposta.Error(ex.Message);
                return resposta;
            }
        }

        public async Task<ResponseDto<List<CategoriaProdutoDto>>> Get(Guid id)
        {
            try
            {
                string fullUrl = $"{_urlBase}/api/ProdutosCategorias/categorias/{id}/id";
                string result = await _service!.Get(fullUrl);

                ResponseDto<List<CategoriaProdutoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<CategoriaProdutoDto>>>(result, _options);

                return resposta!;
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> resposta = new ResponseDto<List<CategoriaProdutoDto>>();
                resposta.Error(ex.Message);
                return resposta;
            }
        }

        public async Task<ResponseDto<List<CategoriaProdutoDto>>> Get(string categoria)
        {
            try
            {
                string fullUrl = $"{_urlBase}/api/ProdutosCategorias/categorias/{categoria}/categoria";
                string result = await _service!.Get(fullUrl);

                ResponseDto<List<CategoriaProdutoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<CategoriaProdutoDto>>>(result, _options);

                return resposta!;
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> resposta = new ResponseDto<List<CategoriaProdutoDto>>();
                resposta.Error(ex.Message);
                return resposta;
            }
        }

        public async Task<ResponseDto<List<CategoriaProdutoDto>>> Create(CategoriaProdutoDtoCreate create)
        {
            try
            {
                string fullUrl = $"{_urlBase}/api/ProdutosCategorias/categorias/create";
                string result = await _service!.Post(fullUrl, create);

                ResponseDto<List<CategoriaProdutoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<CategoriaProdutoDto>>>(result, _options);

                return resposta!;
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> resposta = new ResponseDto<List<CategoriaProdutoDto>>();
                resposta.Error(ex.Message);
                return resposta;
            }
        }
        public async Task<ResponseDto<List<CategoriaProdutoDto>>> Update(CategoriaProdutoDtoUpdate categoriaProdutoDtoUpdate)
        {
            try
            {
                string fullUrl = $"{_urlBase}/api/ProdutosCategorias/categorias/update";
                string result = await _service!.Put(fullUrl, categoriaProdutoDtoUpdate);

                ResponseDto<List<CategoriaProdutoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<CategoriaProdutoDto>>>(result, _options);

                return resposta!;
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> resposta = new ResponseDto<List<CategoriaProdutoDto>>();
                resposta.Error(ex.Message);
                return resposta;
            }
        }
        public async Task<ResponseDto<List<CategoriaProdutoDto>>> DesabilitarHabilitar(Guid id)
        {
            try
            {
                string fullUrl = $"{_urlBase}/api/ProdutosCategorias/categorias/{id}/desabilitar";
                string result = await _service!.Put(fullUrl, null!);

                ResponseDto<List<CategoriaProdutoDto>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<CategoriaProdutoDto>>>(result, _options);

                return resposta!;
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> resposta = new ResponseDto<List<CategoriaProdutoDto>>();
                resposta.Error(ex.Message);
                return resposta;
            }
        }
    }
}
