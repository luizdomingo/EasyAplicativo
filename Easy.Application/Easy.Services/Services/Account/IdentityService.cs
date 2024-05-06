using Easy.Services.Dtos;
using Easy.Services.Dtos.UserIdentity;
using Easy.Services.Interfaces.Account;
using Easy.Services.Interfaces.API;
using Easy.Services.Shared;
using System.Text.Json;

namespace Easy.Services.Services.Account
{
    public class IdentityService : IIdentityService
    {
        private readonly IApiService? _services;
        private readonly JsonSerializerOptions _options;
        public IdentityService(IApiService? services)
        {
            _services = services;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            _options = options;
        }

        public async Task<ResponseDto<List<UsuarioCadastroResponse>>> Create(UsuarioCadastroRequest usuarioCadastro)
        {
            try
            {
                string fullUrl = $"{Globais.UrlApiBase}/api/Accounts/cadastrar";
                string result = await _services.Post(fullUrl, usuarioCadastro);
                ResponseDto<List<UsuarioCadastroResponse>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<UsuarioCadastroResponse>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<UsuarioCadastroResponse>> response = new ResponseDto<List<UsuarioCadastroResponse>>();
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;
            }
        }

        public async Task<ResponseDto<List<UsuarioLoginResponse>>> Login(UsuarioLoginRequest usuarioLogin)
        {
            try
            {
                string fullUrl = $"{Globais.UrlApiBase}/api/Accounts/login";
                string result = await _services.Post(fullUrl, usuarioLogin);
                ResponseDto<List<UsuarioLoginResponse>>? resposta = JsonSerializer.Deserialize<ResponseDto<List<UsuarioLoginResponse>>>(result, _options);
                return resposta;
            }
            catch (Exception ex)
            {
                ResponseDto<List<UsuarioLoginResponse>> response = new ResponseDto<List<UsuarioLoginResponse>>();
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;
            }
        }
    }
}
