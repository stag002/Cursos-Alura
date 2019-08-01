using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuRoteiro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "OK";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "OK";

            return View();
        }
    }
}