namespace Easy.Services.Dtos.ProdutoCategoria
{
    public class CategoriaProdutoDto
    {
        public Guid Id { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool Habilitado { get; set; } = true;
        public string? DescricaoCategoria { get; set; }

    }
}
