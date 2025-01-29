using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaNet.Models;

namespace LojaNet.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Incluir()
        {
            var cli = new Cliente();
            return View(cli);
        }
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
    }
}