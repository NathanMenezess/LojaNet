﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaNet.Models;
using LojaNet.BLL;

namespace LojaNet.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Incluir()
        {
            var cli = new Cliente();
            return View(cli);
        }

        [HttpPost]
        public ActionResult Incluir(Cliente cliente)
        {
            try
            {
                var bll = new ClienteBLL();
                bll.Incluir(cliente);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(cliente);
            }
        }
        // GET: Cliente
        public ActionResult Index()
        {
            var bll = new ClienteBLL();
            var lista = bll.ObterTodos();
            return View(lista);
        }
    }
}