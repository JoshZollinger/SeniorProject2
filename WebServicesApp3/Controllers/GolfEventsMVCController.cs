using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebServicesApp3.Models;

namespace WebServicesApp3.Controllers
{
    public class GolfEventsMVCController : Controller
    {
        private GolfEventContext db = new GolfEventContext();

        // GET: GolfEventsMVC
        public ActionResult Index()
        {
            return View(db.GolfEvents.ToList());
        }

        // GET: GolfEventsMVC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfEvent golfEvent = db.GolfEvents.Find(id);
            if (golfEvent == null)
            {
                return HttpNotFound();
            }
            return View(golfEvent);
        }

        // GET: GolfEventsMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GolfEventsMVC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,eventName,startDate,endDate,numRounds")] GolfEvent golfEvent)
        {
            if (ModelState.IsValid)
            {
                db.GolfEvents.Add(golfEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(golfEvent);
        }

        // GET: GolfEventsMVC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfEvent golfEvent = db.GolfEvents.Find(id);
            if (golfEvent == null)
            {
                return HttpNotFound();
            }
            return View(golfEvent);
        }

        // POST: GolfEventsMVC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,eventName,startDate,endDate,numRounds")] GolfEvent golfEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(golfEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(golfEvent);
        }

        // GET: GolfEventsMVC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfEvent golfEvent = db.GolfEvents.Find(id);
            if (golfEvent == null)
            {
                return HttpNotFound();
            }
            return View(golfEvent);
        }

        // POST: GolfEventsMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GolfEvent golfEvent = db.GolfEvents.Find(id);
            db.GolfEvents.Remove(golfEvent);
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
