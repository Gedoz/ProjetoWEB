using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TrabalhoAcoes.Models;

namespace TrabalhoAcoes.Controllers
{
    public class AdmController : Controller
    {

        // GET: Adm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Administrador()
        {
            List<Categoria> categorias = MockFactory.MockFactory.GerarListaCategorias(10);

            ViewBag.Categorias = categorias;

            return View();
        }

        public ActionResult ListaDeEntidades()
        {
            List<Entidade> entidades = MockFactory.MockFactory.GerarListaEntidades(10);

            ViewBag.Entidades = entidades;

            return View();
        }

        public ActionResult CadastroDeCategoria()
        {
            return View();
        }

        
    }
}