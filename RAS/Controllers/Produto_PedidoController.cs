using RAS.Data;
using RAS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAS.Controllers
{
    public class Produto_PedidoController : Controller
    {
        //private static List<ClienteL clientes = new List<Cliente>();
        public IActionResult Index()
        {
            using(var data = new Produto_PedidoData())
            return View(data.Read());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto_Pedido produto_Pedido)
        {

            using (var date = new Produto_PedidoData())
                date.Create(produto_Pedido);

            return RedirectToAction("Index");
        }
        /*

        [HttpPost]
        public IActionResult Read(IFormCollection produto_Pedido)
        {
            int         qtd             = Convert.ToInt32(produto_Pedido["Qtd"]);
            double      valor           = Convert.ToDouble(produto_Pedido["Valor"]);

           
            return View("Create");
        }
        */

        public IActionResult Delete(Produto_Pedido produto_Pedido)
        {
            using (var data = new Produto_PedidoData())
                data.Delete(produto_Pedido.Pedidos_id, produto_Pedido.Produtos_id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            using (var data = new Produto_PedidoData())
                return View(data.Read(id));
        }

        [HttpPost]
        public IActionResult Update(Produto_Pedido produto_Pedido)
        {

            if(!ModelState.IsValid)
                return View(produto_Pedido);

            using (var data = new Produto_PedidoData())
                data.Update(produto_Pedido);

            return RedirectToAction("Index");
        }
    }
}