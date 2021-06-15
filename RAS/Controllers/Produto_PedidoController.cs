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
        /*
        public IActionResult Index()
        {
            using (var data = new ProdutoData())
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

            if (!ModelState.IsValid)
                return View(produto_Pedido);

            using (var data = new Produto_PedidoData())
                data.Update(produto_Pedido);

            return RedirectToAction("Index");
        }
        */
        
        public IActionResult Index()
        {
            List<Item> lista = new List<Item>();

            var carrinho = HttpContext.Session.GetString("Carrinho");

            if (carrinho != null)
            {
                //TODO Converter String para Lista(Json)
                lista = System.Text.Json.JsonSerializer.Deserialize<List<Item>>(carrinho);
            }

            return View(lista);

        }

        
        [HttpGet]
        public IActionResult Comprar(int id, int qtd)
        {
            List<Item> lista = new List<Item>();

            var carrinho = HttpContext.Session.GetString("Carrinho");

            if (carrinho != null)
            {
                //TODO Converter String para Lista(Json)
                lista = System.Text.Json.JsonSerializer.Deserialize<List<Item>>(carrinho);
            }


            using (var data = new ProdutoData())
            {

                var item = lista.SingleOrDefault(i => i.Produto.Produtos_id == id);

                if (item == null)
                {
                    Produto produto = data.Read(id);

                    item = new Item();
                    item.Produto = produto;
                    item.Qtd = qtd;
                    item.Valor = item.Produto.Valor;
                    lista.Add(item);
                }
                else
                {
                    item.Qtd += qtd;
                }


                //TODO Converter Lista para String (Json)
                carrinho = System.Text.Json.JsonSerializer.Serialize<List<Item>>(lista);

                HttpContext.Session.SetString("Carrinho", carrinho);

                return RedirectToAction("Index");
            }
        }

        
        [HttpGet]
        public IActionResult Remover(int id)
        {
            List<Item> lista = new List<Item>();

            var carrinho = HttpContext.Session.GetString("Carrinho");

            if (carrinho != null)
            {
                //TODO Converter String para Lista(Json)
                lista = System.Text.Json.JsonSerializer.Deserialize<List<Item>>(carrinho);
            }


            using (var data = new ProdutoData())
            {

                var item = lista.SingleOrDefault(i => i.Produto.Produtos_id == id);
                lista.Remove(item);

                //TODO Converter Lista para String (Json)
                carrinho = System.Text.Json.JsonSerializer.Serialize<List<Item>>(lista);

                HttpContext.Session.SetString("Carrinho", carrinho);

                return RedirectToAction("Index");
            }
        }
    }
}