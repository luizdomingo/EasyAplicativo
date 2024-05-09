﻿using System.ComponentModel.DataAnnotations;

namespace Easy.Services.Dtos.PedidoSituacao
{
    public class SituacaoPedidoDtoCreate
    {
        [Display(Name = "Situação do pedido")]
        [Required(ErrorMessage = "Informe a {0}")]
        [MaxLength(80, ErrorMessage = "Quantidae de caracteres deve ser menor ou igual {0}")]
        public string? DescricaoSituacao { get; set; }
    }
}
