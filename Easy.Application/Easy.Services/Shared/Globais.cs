using Easy.Services.Dtos.UserIdentity;

namespace Easy.Services.Shared
{
    public static class Globais
    {
        public static string UrlApiBase;

        static UsuarioLoginResponse _userLogado = new UsuarioLoginResponse();

        public static string GetToken()
        {
            return _userLogado.AccessToken;
        }

        public static void SetToken(UsuarioLoginResponse UserLogado)
        {
            _userLogado = UserLogado;
        }
        public static void SetUrlApiBase(string url)
        {
            UrlApiBase = url;
        }


    }
}
