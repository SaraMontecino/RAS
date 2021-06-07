using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RAS.Models
{
    public class Colaborador : Pessoa
    {
        [Display(Name = "Remuneração")]
        [Required(ErrorMessage = "Campo remuneração obrigatório")]
        public decimal Remuneracao { get; set; }

        [Display(Name = "Comissão")]
        [Required(ErrorMessage = "Campo comissao obrigatório")]
        public decimal Comissao { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Campo Login obrigatório")]
        [MaxLength(50)]
        public string Login { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo Senha obrigatório")]
        [MaxLength(6)]
        public string Senha { get; set; }
    }
}
