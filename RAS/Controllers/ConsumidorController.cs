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
    public class ConsumidorController : Controller
    {
        //private static List<ClienteL clientes = new List<Cliente>();
        public IActionResult Index()
        {
            using(var data = new ConsumidorData())
            return View(data.Read());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Consumidor consumidor)
        {
            
            using (var data = new ConsumidorData())
                data.Create(consumidor);

            return RedirectToAction("Index");
        }

/*
        [HttpPost]
        public IActionResult Read(IFormCollection consumidor)
        {
            string nome         = consumidor["Nome"];
            double cashback     = Convert.ToDouble(consumidor["Cashback"]);
            int faixa_etaria    = Convert.ToInt32(consumidor["FaixaEtaria"]);

           
            return View("Create");
        }
*/
        public IActionResult Delete(int id)
        {
            using (var data = new ConsumidorData())
                data.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            using (var data = new ConsumidorData())
                return View(data.Read(id));
        }

        [HttpPost]
        public IActionResult Update(int id, Consumidor consumidor)
        {
            consumidor.Pessoas_id = id;

            if(!ModelState.IsValid)
                return View(consumidor);

            using (var data = new ConsumidorData())
                data.Update(consumidor);

            return RedirectToAction("Index");
        }
    }
}
