﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThueTro_DACS.Models;

namespace ThueTro_DACS.Controllers
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
    }
}