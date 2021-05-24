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
        public IActionResult Index(Colaborador novoColaborador)
        {
            return View(novoColaborador);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection colaborador)
        {
            
            double remuneracao      = colaborador["Remuneracao"];
            double comissao         = colaborador["Comissao"];
            string login            = colaborador["Login"];
            string senha            = colaborador["Senha"];
           

            var novoColaborador          = new colaborador();
            novoColaborador.Remuneracao  = colaborador["Remuneracao"];
            novoColaborador.Comissao     = colaborador["Comissao"];
            novoColaborador.Login        = colaborador["Login"];
            novoColaborador.Senha        = colaborador["Senha"];

            using (var data = new ColaboradorData())
                data.Create(novoColaborador);

            return RedirectToAction("Index", novoColaborador);
        }

        [HttpPost]
        public IActionResult Read(IFormCollection colaborador)
        {
            double remuneracao      = colaborador["Remuneracao"];
            double comissao         = colaborador["Comissao"];
            string login            = colaborador["Login"];
            string senha            = colaborador["Senha"];

           
            return View("Create");
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
