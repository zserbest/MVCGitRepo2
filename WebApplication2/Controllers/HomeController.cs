using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int a = 0;
            a++;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hello World!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hello World2!";

            return View();
        }
    }
}