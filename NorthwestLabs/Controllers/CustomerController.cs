using NorthwestLabs.DAL;
using NorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
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
            String assays = form["quoteAssays"].ToString();
            String ClientID = form["ClientID"].ToString();

            Customer customer = db.Customers.Find(ClientID);

            ViewBag.Name = customer.CustFirstName + " " + customer.CustLastName;
            ViewBag.Email = customer.Email;
            if (customer.CustFirstName != null && customer.Email != null)
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);


                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("blowoutrentals88@gmail.com", "byuis2018");
                MailMessage mail = new MailMessage();

                //Setting From , To and CC
                mail.From = new MailAddress("labsnorthwest0@gmail.com", "Northwest Labs");
                mail.To.Add(new MailAddress(customer.Email));
                mail.CC.Add(new MailAddress("labsnorthwest0@gmail.com"));
                mail.Subject = "Northwest Labs Quote Request Submitted Successfully";
                mail.Body = "Thank you, " + customer.CustFirstName + " " + customer.CustLastName + ", for contacting Northwest Labs! A sales representative will review your request and respond promptly.";
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;


                smtpClient.Send(mail);
            }
            return View("QuoteConf", form);
        }

        public ActionResult QuoteConf(FormCollection form)
        {
            return View();
        }
    }
}