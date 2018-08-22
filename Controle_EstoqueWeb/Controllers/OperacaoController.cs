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
        public ActionResult EntradaEstoque()
        {
            return View();
        }

        public ActionResult SaidaEstoque()
        {
            return View();
        }

        public ActionResult LançamentoPerdaProduto()
        {
            return View();
        }

        public ActionResult Invetario()
        {
            return View();
        }
    }
}