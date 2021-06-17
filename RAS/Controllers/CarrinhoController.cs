using RAS.Data;
using RAS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RAS.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            List<Produto_Pedido> lista = new List<Produto_Pedido>();

            var carrinho = HttpContext.Session.GetString("Carrinho");

            if (carrinho != null)
            {
                //TODO Converter String para Lista(Json)
                lista = System.Text.Json.JsonSerializer.Deserialize<List<Produto_Pedido>>(carrinho);
            }

            return View(lista);

        }

        [HttpGet]
        public IActionResult Comprar(int id, int qtd)
        {
            List<Produto_Pedido> lista = new List<Produto_Pedido>();

            var carrinho = HttpContext.Session.GetString("Carrinho");

            if (carrinho != null)
            {
                //TODO Converter String para Lista(Json)
                lista = System.Text.Json.JsonSerializer.Deserialize<List<Produto_Pedido>>(carrinho);
            }


            using (var data = new ProdutoData())
            {

                var item = lista.SingleOrDefault(i => i.Produto.Produtos_id == id);

                if (item == null)
                {
                    Produto produto = data.Read(id);

                    item = new Produto_Pedido();
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
                carrinho = System.Text.Json.JsonSerializer.Serialize<List<Produto_Pedido>>(lista);

                HttpContext.Session.SetString("Carrinho", carrinho);

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Remover(int id)
        {
            List<Produto_Pedido> lista = new List<Produto_Pedido>();

            var carrinho = HttpContext.Session.GetString("Carrinho");

            if (carrinho != null)
            {
                //TODO Converter String para Lista(Json)
                lista = System.Text.Json.JsonSerializer.Deserialize<List<Produto_Pedido>>(carrinho);
            }


            using (var data = new ProdutoData())
            {

                var item = lista.SingleOrDefault(i => i.Produto.Produtos_id == id);
                lista.Remove(item);

                //TODO Converter Lista para String (Json)
                carrinho = System.Text.Json.JsonSerializer.Serialize<List<Produto_Pedido>>(lista);

                HttpContext.Session.SetString("Carrinho", carrinho);

                return RedirectToAction("Index");
            }
        }
    }
}
