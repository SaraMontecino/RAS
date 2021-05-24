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
    public class PedidoController : Controller
    {
        //private static List<ClienteL clientes = new List<Cliente>();
        public IActionResult Index(Pedido novoPedido)
        {
            return View(novoPedido);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection pedido)
        {
            
            DateTime    data             = Convert.ToDateTime(pedido["Data"]);
            double      valor            = Convert.ToDouble(pedido["Valor"]);
            double      desconto         = Convert.ToDouble(pedido["Desconto"]);
           

            var novoPedido            = new Pedido();
            novoPedido.Data           = Convert.ToDateTime(pedido["Data"]);
            novoPedido.Valor          = Convert.ToDouble(pedido["Valor"]);
            novoPedido.Desconto       = Convert.ToDouble(pedido["Desconto"]);

            using (var date = new PedidoData())
                date.Create(novoPedido);

            return RedirectToAction("Index", novoPedido);
        }

        [HttpPost]
        public IActionResult Read(IFormCollection pedido)
        {
            DateTime    data             = Convert.ToDateTime(pedido["Data"]);
            double      valor            = Convert.ToDouble(pedido["Valor"]);
            double      desconto         = Convert.ToDouble(pedido["Desconto"]);

           
            return View("Create");
        }

        public IActionResult Delete(int id)
        {
            using (var data = new PedidoData())
                data.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            using (var data = new PedidoData())
                return View(data.Read(id));
        }

        [HttpPost]
        public IActionResult Update(int id, Pedido pedido)
        {
            pedido.Pedidos_id = id;

            if(!ModelState.IsValid)
                return View(pedido);

            using (var data = new PedidoData())
                data.Update(pedido);

            return RedirectToAction("Index");
        }
    }
}