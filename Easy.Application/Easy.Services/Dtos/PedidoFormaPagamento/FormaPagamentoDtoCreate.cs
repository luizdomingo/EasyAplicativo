﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Easy.Services.Dtos.PedidoFormaPagamento
{
    public class FormaPagamentoDtoCreate
    {
        [MaxLength(80, ErrorMessage = "Número máximo de caracteres {0}")]
        [DisplayName("Descricao Forma de Pagamento")]
        [Required(ErrorMessage = "Informe a {0}")]
        public string? DescricaoFormaPg { get; set; }

    }
}
