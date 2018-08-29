﻿using Lab21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21.Controllers
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
        [HttpGet]
        public ActionResult NewUser()
        {
            return View();
        }
         [HttpPost]
        public ActionResult NewUser(NewUserModel model)
        {
            ViewBag.FirstName = model.FirstName;
            return View();
        }
        

    }
}