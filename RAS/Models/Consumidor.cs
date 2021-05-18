using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RAS.Models
{
    public class Consumidor : Pessoa
    {
        
        [Display(Name = "Cashback")]
        public double Cashback { get; set; }

        [Display(Name = "Faixa Etária")]
        [Required(ErrorMessage = "Campo faixa etária obrigatório")]
        [MinLength(2)]
        public string Faixa_etaria { get; set; }

    }
}
