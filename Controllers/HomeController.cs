﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lash_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "GARRISON LASH";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information ";

            return View();
        }
    }
}