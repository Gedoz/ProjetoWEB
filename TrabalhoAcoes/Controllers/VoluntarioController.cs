using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoAcoes.Filtro;
using TrabalhoAcoes.Models;

namespace TrabalhoAcoes.Controllers
{
    public class VoluntarioController : Controller
    {
        // GET: Voluntario
        [FiltroAcesso]
        public ActionResult Index()
        {
            if (Session["Usuario"] == null)
            {
                return RedirectToAction("Login", "Login");
            }

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