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
    public class ProdutoController : Controller
    {
        //private static List<ClienteL clientes = new List<Cliente>();
        public IActionResult Index(Produto novoProduto)
        {
            return View(novoProduto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection produto)
        {
            
            int    tipo             = Convert.ToInt32(produto["Tipo"]);
            string descricao        = produto["Descricao"];
            int    estoque          = Convert.ToInt32(produto["Estoque"]);
            double valor            = Convert.ToDouble(produto["Valor"]);
           

            var novoProduto            = new Produto();
            novoProduto.Tipo           = Convert.ToInt32(produto["Tipo"]);
            novoProduto.Descricao      = produto["Descricao"];
            novoProduto.Estoque        = Convert.ToInt32(produto["Estoque"]);
            novoProduto.Valor          = Convert.ToDouble(produto["Valor"]);

            using (var data = new ProdutoData())
                data.Create(novoProduto);

            return RedirectToAction("Index", novoProduto);
        }

        [HttpPost]
        public IActionResult Read(IFormCollection produto)
        {
            int    tipo             = Convert.ToInt32(produto["Tipo"]);
            string descricao        = produto["Descricao"];
            int    estoque          = Convert.ToInt32(produto["Estoque"]);
            double valor            = Convert.ToDouble(produto["Valor"]);

           
            return View("Create");
        }

        public IActionResult Delete(int id)
        {
            using (var data = new ProdutoData())
                data.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            using (var data = new ProdutoData())
                return View(data.Read(id));
        }

        [HttpPost]
        public IActionResult Update(int id, Produto produto)
        {
            produto.Produtos_id = id;

            if(!ModelState.IsValid)
                return View(produto);

            using (var data = new ProdutoData())
                data.Update(produto);

            return RedirectToAction("Index");
        }
    }
}