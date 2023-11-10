using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ItemController : Controller
    {
        private ItemServico itemServico = new ItemServico();   

        // GET: Item
        public ActionResult Index()
        {
            return View();
        }
        // GET: ItemTema/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemTema/Create
        [HttpPost]
        public ActionResult Create(ItemTema itemTema)
        {
            try
            {
                //context.Produtos.Add(produto);
                //context.SaveChanges();
                itemServico.gravar(itemTema);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(itemTema);
            }
        }
    }
}