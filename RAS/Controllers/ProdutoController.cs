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
        
        public IActionResult Index()
        {
            using(var data = new ProdutoData())
            return View(data.Read());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            
            using (var data = new ProdutoData())
                data.Create(produto);

            return RedirectToAction("Index");
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