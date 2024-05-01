namespace Easy.Services.Dtos.UserIdentity
{
    public class UsuarioLoginResponse
    {
        public bool Sucesso => Erros.Count == 0;

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public List<string> Erros { get; set; }

        public UsuarioLoginResponse() => Erros = new List<string>();

        public UsuarioLoginResponse(bool sucesso, string accessToken, string refreshToken) : this()
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public void AdicionarErro(string erro) =>
            Erros.Add(erro);

        public void AdicionarErros(IEnumerable<string> erros) =>
            Erros.AddRange(erros);


    }
}
