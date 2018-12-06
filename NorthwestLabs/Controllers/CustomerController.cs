using NorthwestLabs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class CustomerController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();

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

        [HttpGet]
        public ActionResult GetQuote()
        {
            return View(db.Assays.ToList());
        }
        
        [HttpPost]
        public ActionResult GetQuote(FormCollection form)
        {
            return View();
        }
    }
}