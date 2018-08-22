using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controle_EstoqueWeb.Controllers
{
    public class GraficoController : Controller
    {
        // GET: Grafico
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }

        public ActionResult PerdasMes()
        {
            return View();
        }

     
    }
}