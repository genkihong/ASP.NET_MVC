using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Expert()
        {
           return View();
        }

        public ActionResult Knowledge()
        {
            return View();
        }
    }
}