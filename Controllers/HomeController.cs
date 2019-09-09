using System;
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
            ViewBag.Message = "this is where you put something about yourself";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information for you";

            return View();
        }
    }
}