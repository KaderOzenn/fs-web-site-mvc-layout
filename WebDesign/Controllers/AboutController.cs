using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDesign.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {

            ViewBag.Title = "P&B | Hakkımızda";
            return View();
        }
    }
}