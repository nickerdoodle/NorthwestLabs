using NorthwestLabs.DAL;
using NorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
//using System.DirectoryServices.ActiveDirectory;

namespace NorthwestLabs.Controllers
{
    public class HomeController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();
        [Authorize]
        public ActionResult Index()
        {
            return View();
            
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

        public ActionResult EmployeeIndex()
        {
            return View();
        }

        public ActionResult Stats()
        {
            return View();
        }




        
        public ActionResult Login()
        {
            
            return View();
        }


        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String username = form["Username"].ToString();
            String password = form["Password"].ToString();

            var currentCustomerUser = db.Database.SqlQuery<CustomerLogin>(
            "Select * " +
            "FROM CustomerLogin " +
            "WHERE CustUserName = '" + username + "' AND " +
            "CustPassword = '" + password + "'");

            var currentEmployeeUser = db.Database.SqlQuery<EmployeeLogin>(
            "Select * " +
            "FROM EmployeeLogin " +
            "WHERE EmpUserName = '" + username + "' AND " +
            "EmpPassword = '" + password + "'");

            if (currentCustomerUser.Count() > 0)
            {
                var id = db.Database.SqlQuery<Customer>("Select CustID " +
                    "From Customer Inner Join CustomerLogin " +
                    "On Customer.UserName = CustomerLogin.UserName;");
                ViewBag.ClientID = id;
                FormsAuthentication.SetAuthCookie(username, rememberMe);
                return RedirectToAction("Index", "Home", new { userlogin = username });
            }
            else if (currentEmployeeUser.Count() > 0)
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);
                return RedirectToAction("EmployeeIndex", "Home", new { userlogin = username });
            }
            {
                return View();
            }
        }
    }
}