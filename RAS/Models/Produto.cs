using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RAS.Models
{
    public class Produto
    {
        public int? Produtos_id { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "Campo tipo obrigatório")]
        public int Tipo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo Descrição obrigatório")]
        public string Descricao { get; set; }

        [Display(Name = "Estoque")]
        [Required(ErrorMessage = "Campo Estoque obrigatório")]
        public int Estoque { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Campo valor obrigatório")]
        public decimal Valor { get; set; }
    }
}
