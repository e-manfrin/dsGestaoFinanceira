﻿using GestaoFinanceira.API.Models;
using System.ComponentModel.DataAnnotations;

namespace GestaoFinanceira.API.Dtos
{
    public class CreateContaDto
    {
        [Required(ErrorMessage = "O Campo Data é obrigatório")]
        public string Data { get; set; }

        [Required(ErrorMessage = "O Campo Descricao é obrigatório")]
        [StringLength(100, ErrorMessage = "O limite do campo Descricao é de 20 caracteries")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Campo Valor é obrigatório")]
        public double Valor { get; set; }
        public int CategoriaId { get; set; }
    }
}