﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabalhoAcoes.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CriarConta()
        {
            return View();
        }

        public ActionResult Autenticar(string usuario, string senha)
        {
            return RedirectToAction("Login");
        }


    }
}