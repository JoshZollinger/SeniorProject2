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
    public class GolfScoresMVCController : Controller
    {
        private GolfScoreContext db = new GolfScoreContext();

        // GET: GolfScoresMVC
        public ActionResult Index()
        {
            return View(db.GolfScores.ToList());
        }

        // GET: GolfScoresMVC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfScore golfScore = db.GolfScores.Find(id);
            if (golfScore == null)
            {
                return HttpNotFound();
            }
            return View(golfScore);
        }

        // GET: GolfScoresMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GolfScoresMVC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Hole1,Hole2,Hole3,Hole4,Hole5,Hole6,Hole7,Hole8,Hole9,Hole10,Hole11,Hole12,Hole13,Hole14,Hole15,Hole16,Hole17,Hole18,roundNum,scoreDate,firstName,lastName,courseName,eventName")] GolfScore golfScore)
        {
            if (ModelState.IsValid)
            {
                db.GolfScores.Add(golfScore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(golfScore);
        }

        // GET: GolfScoresMVC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfScore golfScore = db.GolfScores.Find(id);
            if (golfScore == null)
            {
                return HttpNotFound();
            }
            return View(golfScore);
        }

        // POST: GolfScoresMVC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Hole1,Hole2,Hole3,Hole4,Hole5,Hole6,Hole7,Hole8,Hole9,Hole10,Hole11,Hole12,Hole13,Hole14,Hole15,Hole16,Hole17,Hole18,roundNum,scoreDate,firstName,lastName,courseName,eventName")] GolfScore golfScore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(golfScore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(golfScore);
        }

        // GET: GolfScoresMVC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfScore golfScore = db.GolfScores.Find(id);
            if (golfScore == null)
            {
                return HttpNotFound();
            }
            return View(golfScore);
        }

        // POST: GolfScoresMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GolfScore golfScore = db.GolfScores.Find(id);
            db.GolfScores.Remove(golfScore);
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
