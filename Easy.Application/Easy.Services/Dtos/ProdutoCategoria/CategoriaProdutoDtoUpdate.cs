﻿using System.ComponentModel.DataAnnotations;

namespace Easy.Services.Dtos.ProdutoCategoria
{
    public class CategoriaProdutoDtoUpdate
    {
        [Required(ErrorMessage = "Informe Id para realizar alteração")]
        public Guid Id { get; set; }

        [StringLength(100, ErrorMessage = "Categoria deve ter no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe Descricao da Categoria")]
        public string? DescricaoCategoria { get; set; }

        [Required(ErrorMessage = "Informe o status")]
        public bool Habilitado { get; set; }
    }
}
