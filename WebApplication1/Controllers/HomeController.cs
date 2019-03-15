using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var filePath = ControllerContext.HttpContext.Request.CurrentExecutionFilePath;
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
        public ActionResult razor1()
        {
            
           
           
            ViewBag.Message = "1";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Start()
        {
            return View();
        }
        public ActionResult AjaxDemo()
        {
            return View();
        }
        public ActionResult Ajax1()
        {
            string s = string.Format("{0:HH:mm:ss}", DateTime.Now);
            return Content(s);
        }
    }
}