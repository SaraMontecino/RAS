using RAS.Data;
using RAS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;


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

        [HttpPost]
        public IActionResult Create(Pedido pedido)
        {
            //O ModeState é uma propriedade da classe Controller e pode ser
            //acessada a partir das classes que herdam de System.Web.Mvc.Controller.
            //Ele representa uma coleção de pares nome/valor que são submetidos
            //ao servidor durante o POST e também contém uma coleção de mensagens
            //de erros para cada calor submetido
            string json = HttpContext.Session.GetString("itens");
            List<Produto_Pedido> itens = JsonSerializer.Deserialize<List<Produto_Pedido>>(json);
            pedido.Itens = itens;
            List<Produto_Pedido> lista = new List<Produto_Pedido>();
            var carrinho = System.Text.Json.JsonSerializer.Serialize<List<Produto_Pedido>>(lista);
            HttpContext.Session.SetString("Carrinho", carrinho);

            Consumidor cosumidor = new Consumidor();

            using (var data = new ConsumidorData())
            {

            }

            using (var data = new PedidoData())
                data.Create(pedido);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public void VincularCpf(int cpf)
        {
            HttpContext.Session.SetString("cpf", cpf.ToString());
        }

    }
}