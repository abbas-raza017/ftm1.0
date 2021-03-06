﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FTM1._0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult dashboard()
        {
            return View();
        }

        public ActionResult brand()
        {
            return View();
        }

        public ActionResult blogs()
        {
            return View();
        }

        public ActionResult categories()
        {
            return View();
        }

        public ActionResult brandWebsite()
        {
            return View();
        }

        public ActionResult FAQs()
        {
            return View();
        }
    }
}