using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDesign.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Title = "P&B | Blog";
            return View();
        }

        public ActionResult Category()
        {
            return View();
        }

        public ActionResult Best()
        {
            return View();
        }

        public ActionResult Detaıl()
        {
            return View();
        }
    }
}
