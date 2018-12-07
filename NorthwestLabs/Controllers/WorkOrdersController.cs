using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NorthwestLabs.DAL;
using NorthwestLabs.Models;

namespace NorthwestLabs.Controllers
{
    public class WorkOrdersController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();

        // GET: WorkOrders
        public ActionResult Index()
        {
            var workOrders = db.WorkOrders.Include(w => w.Customer);
            return View(workOrders.ToList());

        }

        public ActionResult PriorityList()
        {
            var priority = db.Database.SqlQuery<WorkOrder>("SELECT * FROM WorkOrder WHERE Priority = 1 ORDER BY ShipDate; ");
            return View(priority);
        }

        // GET: WorkOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // GET: WorkOrders/Create
        public ActionResult Create()
        {
            ViewBag.CustID = new SelectList(db.Customers, "CustID", "CustFirstName");
            return View();
        }

        // POST: WorkOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderID,CustID,CustInstructions,SpecialDiscount,Priority,ShipDate")] WorkOrder workOrder)
        {
            if (ModelState.IsValid)
            {
                db.WorkOrders.Add(workOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustID = new SelectList(db.Customers, "CustID", "CustFirstName", workOrder.CustID);
            return View(workOrder);
        }

        // GET: WorkOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrders.Find(id);
            //workOrder.Customer.CustID = workOrder.CustID;

            if (workOrder == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustID = new SelectList(db.Customers, "CustID", "CustFirstName", workOrder.Customer.CustID);

            return View(workOrder);
        }

        // POST: WorkOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderID, CustID,CustInstructions,SpecialDiscount,Priority,ShipDate")] WorkOrder workOrder)
        {
            if (ModelState.IsValid)
            {
                //workOrder.Customer = db.Customers.Find(workOrder.CustID);
                //db.Entry(workOrder).State = EntityState.Modified;
                //db.Database.ExecuteSqlCommand(
                //    "Update WorkOrder SET (CustInstructions, SpecialDiscount, Priority, ShipDate) " +
                //    "values(" + workOrder.CustInstructions + ", " + workOrder.SpecialDiscount + ", " +
                //    workOrder.Priority + ", " + workOrder.ShipDate + ") " +
                //    "Where CustID = " + workOrder.CustID + ";");

                //db.Database.ExecuteSqlCommand(
                //    "Update WorkOrder SET CustInstructions = " + workOrder.CustInstructions +
                //    ", SpecialDiscount = " + workOrder.SpecialDiscount +
                //    ", Priority = " + workOrder.Priority +
                //    ", ShipDate = " + workOrder.ShipDate +
                //    " Where CustID = " + workOrder.CustID + 
                //    " And OrderID = " + workOrder.OrderID + ";");
                db.Entry(workOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustID = new SelectList(db.Customers, "CustID", "CustFirstName", workOrder.Customer.CustID);
            return View(workOrder);
        }

        // GET: WorkOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // POST: WorkOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkOrder workOrder = db.WorkOrders.Find(id);
            db.WorkOrders.Remove(workOrder);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
