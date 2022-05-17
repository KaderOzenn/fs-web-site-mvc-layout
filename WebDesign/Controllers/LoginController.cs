using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDesign.Models;

namespace WebDesign.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        pnbDBEntities1 db = new pnbDBEntities1();
        public ActionResult Index()
        {
            return View();
        }
    }
}