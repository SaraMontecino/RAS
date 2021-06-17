using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RAS.Models
{
    public class Produto_Pedido
    {
        public int? Pedidos_id { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Campo quantidade obrigatório")]
        public int Qtd { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Campo valor obrigatório")]
        public decimal Valor { get; set; }

        public Produto Produto { get; set; }

    }
}
