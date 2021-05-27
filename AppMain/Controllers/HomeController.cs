using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppSub1;

namespace AppMain.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var test = new Class1();
            test.Test();
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}