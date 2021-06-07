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
    public class ColaboradorController : Controller
    {
        //private static List<ClienteL clientes = new List<Cliente>();
        public IActionResult Index()
        {
            using(var data = new ColaboradorData())
            return View(data.Read());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Colaborador colaborador)
        {
           
            using (var data = new ColaboradorData())
                data.Create(colaborador);

            return RedirectToAction("Index");
        }

       
        public IActionResult Delete(int id)
        {
            using (var data = new ColaboradorData())
                data.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            using (var data = new ColaboradorData())
                return View(data.Read(id));
        }

        [HttpPost]
        public IActionResult Update(int id, Colaborador colaborador)
        {
            colaborador.Pessoas_id = id;

            if(!ModelState.IsValid)
                return View(colaborador);

            using (var data = new ColaboradorData())
                data.Update(colaborador);

            return RedirectToAction("Index");
        }
    }
}
