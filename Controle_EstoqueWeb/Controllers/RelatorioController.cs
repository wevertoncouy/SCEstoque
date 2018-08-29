﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controle_EstoqueWeb.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorio
        [Authorize]
        public ActionResult PosicaoEstoque()
        {
            return View();
        }

        [Authorize]
        public ActionResult Resuprimento()
        {
            return View();
        }

    }
}