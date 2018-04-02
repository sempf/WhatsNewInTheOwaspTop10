﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Privacy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string serviceUrl = "http://sempf.net/some/private/information";
            WebRequest request = WebRequest.Create(serviceUrl);
            try
            {
                WebResponse response = request.GetResponse();
            }
            catch { }
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