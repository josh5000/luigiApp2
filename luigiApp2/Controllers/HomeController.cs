﻿using luigiApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace luigiApp2.Controllers
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

        public ActionResult Basic()
        {
            return View();
        }

        public ActionResult Advanced()
        {
            var person = new Person
            {
                FirstName = "Rollin J.",
                LastName = "Nelson"
            };

            return View(person);
        }
    }
}