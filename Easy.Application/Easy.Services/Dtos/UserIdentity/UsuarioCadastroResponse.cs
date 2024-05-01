namespace Easy.Services.Dtos.UserIdentity
{
    public class UsuarioCadastroResponse
    {
        public bool Sucesso { get; set; }
        public List<string> Erros { get; set; }

        public UsuarioCadastroResponse() =>
            Erros = new List<string>();

        public UsuarioCadastroResponse(bool Sucesso = true) : this() =>
            this.Sucesso = Sucesso;

        public void AdicionarErros(IEnumerable<string> erros) =>
            Erros.AddRange(erros);
    }
}