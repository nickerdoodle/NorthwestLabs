﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PharmacologyCatalog()
        {
            return View();
        }

        public ActionResult ProtocolCatalog()
        {
            return View();
        }

        public ActionResult GetQuote()
        {
            return View();
        }
    }
}