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
    public class GolfCoursesMVCController : Controller
    {
        private GolfCourseContext db = new GolfCourseContext();

        // GET: GolfCoursesMVC
        public ActionResult Index()
        {
            return View(db.GolfCourses.ToList());
        }

        // GET: GolfCoursesMVC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfCourse golfCourse = db.GolfCourses.Find(id);
            if (golfCourse == null)
            {
                return HttpNotFound();
            }
            return View(golfCourse);
        }

        // GET: GolfCoursesMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GolfCoursesMVC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Par1,Par2,Par3,Par4,Par5,Par6,Par7,Par8,Par9,Par10,Par11,Par12,Par13,Par14,Par15,Par16,Par17,Par18,courseName")] GolfCourse golfCourse)
        {
            if (ModelState.IsValid)
            {
                db.GolfCourses.Add(golfCourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(golfCourse);
        }

        // GET: GolfCoursesMVC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfCourse golfCourse = db.GolfCourses.Find(id);
            if (golfCourse == null)
            {
                return HttpNotFound();
            }
            return View(golfCourse);
        }

        // POST: GolfCoursesMVC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Par1,Par2,Par3,Par4,Par5,Par6,Par7,Par8,Par9,Par10,Par11,Par12,Par13,Par14,Par15,Par16,Par17,Par18,courseName")] GolfCourse golfCourse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(golfCourse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(golfCourse);
        }

        // GET: GolfCoursesMVC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfCourse golfCourse = db.GolfCourses.Find(id);
            if (golfCourse == null)
            {
                return HttpNotFound();
            }
            return View(golfCourse);
        }

        // POST: GolfCoursesMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GolfCourse golfCourse = db.GolfCourses.Find(id);
            db.GolfCourses.Remove(golfCourse);
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
