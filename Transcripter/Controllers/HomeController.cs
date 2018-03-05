using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Transcripter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Transcripta Search the university records and down load a student transcript.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact";

            return View();
        }
    }
}