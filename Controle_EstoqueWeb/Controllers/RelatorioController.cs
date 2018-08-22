using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controle_EstoqueWeb.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorio
        public ActionResult PosicaoEstoque()
        {
            return View();
        }
        public ActionResult Resuprimento()
        {
            return View();
        }

    }
}