﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDesign.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Slider()
        {
            return View();
        }
        public ActionResult İnfo()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

       

        public ActionResult Counter()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        
    }
}