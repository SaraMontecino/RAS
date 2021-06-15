using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAS.Models
{
    public class Item
    {
        //propriedades & atributos

        public int Pedidos_id { get; set; }
        public int Qtd { get; set; }
        public decimal Valor { get; set; }
        public Produto Produto { get; set; } //is - a


    }
}
