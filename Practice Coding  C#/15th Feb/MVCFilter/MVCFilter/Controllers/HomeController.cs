using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilter.Controllers
{
   // [HandleErrorAttribute]
    public class HomeController : Controller
    {

        // [HandleErrorAttribute]
        
        
        public ActionResult Index()
        {
            //throw new Exception("this is exception");
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