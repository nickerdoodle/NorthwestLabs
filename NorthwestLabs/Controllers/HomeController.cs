using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.DirectoryServices.ActiveDirectory;

namespace NorthwestLabs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Login", "Account");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Northwest Labs is a leader in compound analysis. We pride ourselves in building customer trust" +
                " by promptly and reliably delivering results for your products. We have grown in recent years and expect to continue to grow in the future.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}