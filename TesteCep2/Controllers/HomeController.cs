using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteCep2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sistema TesteCEP.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contatos.";

            return View();
        }
    }
}