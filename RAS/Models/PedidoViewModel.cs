using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAS.Models
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public DateTime Data { get; set; }
        public string NomeColaborador { get; set; }
        public decimal Total { get; set; }
        public List<ProdutoPedidoViewModel> Itens { get; set; }

    }
}
