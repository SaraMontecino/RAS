using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RAS.Models
{
    public class Pedido
    {
        public int? IdPedido { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Campo Data obrigatório")]
        public DateTime Data { get; set; }

        [Display(Name = "Valor")]
        public double Valor { get; set; }

        [Display(Name = "Desconto")]
        public double Desconto { get; set; }

        
        //PERGUNTAR DA CHAVE ESTRANGEIRA Colaborador_id e consumidor_id 
    }
}
