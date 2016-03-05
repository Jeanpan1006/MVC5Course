using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();　
        } 
        
        //註解註解:first lesson
        ////註解註解:first lesson
        //註解註解:first lesson
        //註解註解:first lesson

        public ActionResult About()
        {
            //todo: UNDONE
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