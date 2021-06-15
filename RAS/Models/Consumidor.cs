using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RAS.Models
{
    public class Consumidor : Pessoa
    {
        
        [Display(Name = "Faixa Etária")]
        [Required(ErrorMessage = "Campo faixa etária obrigatório")]
        public int FaixaEtaria { get; set; }

    }
}
