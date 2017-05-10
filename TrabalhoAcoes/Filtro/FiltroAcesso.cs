using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace TrabalhoAcoes.Filtro
{
    public class FiltroAcesso : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object usuarioLogado = filterContext.HttpContext.Session["Usuario"];

            if(usuarioLogado == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                                            new RouteValueDictionary(
                                                    new { action = "Login", controller = "Login" }));
            }

        }
    }
}