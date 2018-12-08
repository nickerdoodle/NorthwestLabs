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
    public class TestInstancesController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();

        // GET: TestInstances
        public ActionResult Index()
        {
            var testInstances = db.TestInstances.Include(t => t.TestType);
            return View(testInstances.ToList());
        }

        // GET: TestInstances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestInstance testInstance = db.TestInstances.Find(id);
            if (testInstance == null)
            {
                return HttpNotFound();
            }
            return View(testInstance);
        }

        // GET: TestInstances/Create
        public ActionResult Create()
        {
            ViewBag.TestTypeID = new SelectList(db.TestTypes, "TestTypeID", "TestTypeDesc");
            return View();
        }

        // POST: TestInstances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TestInstanceID,TestTypeID,AssayID,SequenceID,Required,Approved,DateCompleted,BasePrice,DateScheduled,Rerun,RerunComments,Success")] TestInstance testInstance)
        {
            if (ModelState.IsValid)
            {
                db.TestInstances.Add(testInstance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TestTypeID = new SelectList(db.TestTypes, "TestTypeID", "TestTypeDesc", testInstance.TestTypeID);
            return View(testInstance);
        }

        // GET: TestInstances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestInstance testInstance = db.TestInstances.Find(id);
            if (testInstance == null)
            {
                return HttpNotFound();
            }
            ViewBag.TestTypeID = new SelectList(db.TestTypes, "TestTypeID", "TestTypeDesc", testInstance.TestTypeID);
            return View(testInstance);
        }

        // POST: TestInstances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TestInstanceID,TestTypeID,AssayID,SequenceID,Required,Approved,DateCompleted,BasePrice,DateScheduled,Rerun,RerunComments,Success")] TestInstance testInstance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testInstance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TestTypeID = new SelectList(db.TestTypes, "TestTypeID", "TestTypeDesc", testInstance.TestTypeID);
            return View(testInstance);
        }

        // GET: TestInstances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestInstance testInstance = db.TestInstances.Find(id);
            if (testInstance == null)
            {
                return HttpNotFound();
            }
            return View(testInstance);
        }

        // POST: TestInstances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestInstance testInstance = db.TestInstances.Find(id);
            db.TestInstances.Remove(testInstance);
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
