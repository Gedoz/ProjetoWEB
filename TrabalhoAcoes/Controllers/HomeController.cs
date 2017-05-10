using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoAcoes.Filtro;

namespace TrabalhoAcoes.Controllers
{
    public class HomeController : Controller
    {
        [FiltroAcesso]
        public ActionResult Index()
        {
            return View();
        }
        
        
    }
}