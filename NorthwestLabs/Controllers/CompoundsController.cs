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
    public class CompoundsController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();

        // GET: Compounds
        public ActionResult Index()
        {
            return View(db.Compounds.ToList());
        }

        // GET: Compounds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compound compound = db.Compounds.Find(id);
            if (compound == null)
            {
                return HttpNotFound();
            }
            return View(compound);
        }

        public ActionResult PendingCompounds()
        {
            var pending = db.Database.SqlQuery<Compound>(
                "SELECT * FROM Compound WHERE LTNumber " +
                "IS NOT NULL AND OrderID IS " +
                "NOT NULL AND CompName IS NOT NULL " +
                "AND Volume IS NULL; ").ToList();

            return View(pending);
        }

        // GET: Compounds/Create
        public ActionResult Create()
        {

            ViewBag.WeightUnitID = new SelectList(db.WeightUnits, "WeightUnitID", "WeightUnitDesc");

            return View();
        }

        // POST: Compounds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LTNumber,OrderID,CompName,Volume,VolumeUnitID,DateArrived,ReceivedBy,DateDue,ClientWeight,MolecularMass,ConfID,ActualWeight,ActualWeightID,DoseID")] Compound compound)
        {
            if (ModelState.IsValid)
            {
                db.Compounds.Add(compound);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(compound);
        }

        // GET: Compounds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compound compound = db.Compounds.Find(id);
            if (compound == null)
            {
                return HttpNotFound();
            }

            ViewBag.WeightUnitID = new SelectList(db.WeightUnits, "WeightUnitID", "WeightUnitDesc");
            ViewBag.VolumeUnitID = new SelectList(db.VolumeUnits, "VolumeUnitID", "VolumeUnitDesc");

            return View(compound);
        }

        // POST: Compounds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LTNumber,OrderID,CompName,Volume,VolumeUnitID,DateArrived,ReceivedBy,DateDue,ClientWeight,MolecularMass,ConfID,ActualWeight,ActualWeightID,DoseID")] Compound compound)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compound).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(compound);
        }

        // GET: Compounds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compound compound = db.Compounds.Find(id);
            if (compound == null)
            {
                return HttpNotFound();
            }
            return View(compound);
        }

        // POST: Compounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Compound compound = db.Compounds.Find(id);
            db.Compounds.Remove(compound);
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
