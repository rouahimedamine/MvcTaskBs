﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationTask.Controllers
{
    public class AccueilController : Controller
    {
        //
        // GET: /Accueil/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Forget()
        {
            return View();
        }

    }
}
