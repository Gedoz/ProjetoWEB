using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoAcoes.Models;

namespace TrabalhoAcoes.Controllers
{
    public class VoluntarioController : Controller
    {
        // GET: Voluntario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Voluntario()
        {
            List<Acao> acoes = MockFactory.MockFactory.GerarListaAcoes(10);

            ViewBag.Acoes = acoes;

            return View();
        }
    }
}