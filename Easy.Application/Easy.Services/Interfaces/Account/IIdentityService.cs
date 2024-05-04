using Easy.Services.Dtos;
using Easy.Services.Dtos.UserIdentity;

namespace Easy.Services.Interfaces.Account
{
    public interface IIdentityService
    {
        Task<ResponseDto<List<UsuarioLoginResponse>>> Login(UsuarioLoginRequest usuarioLogin);
        Task<ResponseDto<List<UsuarioCadastroResponse>>> Create(UsuarioCadastroRequest usuarioCadastro);
    }
}
