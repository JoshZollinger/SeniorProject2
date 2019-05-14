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
    public class GolfUsersMVCController : Controller
    {
        private GolfUserContext db = new GolfUserContext();

        // GET: GolfUsersMVC
        public ActionResult Index()
        {
            return View(db.GolfUsers.ToList());
        }

        // GET: GolfUsersMVC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfUser golfUser = db.GolfUsers.Find(id);
            if (golfUser == null)
            {
                return HttpNotFound();
            }
            return View(golfUser);
        }

        // GET: GolfUsersMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GolfUsersMVC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,firstName,lastName,userName,password,isNewUser")] GolfUser golfUser)
        {
            if (ModelState.IsValid)
            {
                db.GolfUsers.Add(golfUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(golfUser);
        }

        // GET: GolfUsersMVC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfUser golfUser = db.GolfUsers.Find(id);
            if (golfUser == null)
            {
                return HttpNotFound();
            }
            return View(golfUser);
        }

        // POST: GolfUsersMVC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,firstName,lastName,userName,password,isNewUser")] GolfUser golfUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(golfUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(golfUser);
        }

        // GET: GolfUsersMVC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GolfUser golfUser = db.GolfUsers.Find(id);
            if (golfUser == null)
            {
                return HttpNotFound();
            }
            return View(golfUser);
        }

        // POST: GolfUsersMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GolfUser golfUser = db.GolfUsers.Find(id);
            db.GolfUsers.Remove(golfUser);
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
