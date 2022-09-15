using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult dashboard()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TollFree = "456-456-456";
            return View();
        }

    }
}