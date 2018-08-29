using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controle_EstoqueWeb.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        [Authorize]
        public ActionResult EntradaEstoque()
        {
            return View();
        }

        [Authorize]
        public ActionResult SaidaEstoque()
        {
            return View();
        }

        [Authorize]
        public ActionResult LançamentoPerdaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult Invetario()
        {
            return View();
        }
    }
}