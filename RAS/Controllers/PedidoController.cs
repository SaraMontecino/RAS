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
        /*
        public IActionResult Index()
        {
            using(var data = new PedidoData())
            return View(data.Read());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pedido pedido)
        {
            using (var date = new PedidoData())
                date.Create(pedido);

            return RedirectToAction("Index");
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
        } */

        public IActionResult Index(int id)
        {
            //Criando um objeto data da classe ProdutoData
            using (var data = new PedidoData())
                return View(data.Read(id));
            //data.Read() chama a execução do método Read (Select + From Produtos)
        }

    }
}