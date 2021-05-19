using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RAS.Models
{
    public class Produto_Pedido
    {
        public int? IdProduto { get; set; }
        public int? IdPedido { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Campo quantidade obrigatório")]
        public int Qtd { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Campo valor obrigatório")]
        public double Valor { get; set; }

        public Produto produto { get; set; }

    }
}
