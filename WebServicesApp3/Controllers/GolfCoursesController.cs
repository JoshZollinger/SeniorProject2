using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebServicesApp3.Models;

namespace WebServicesApp3.Controllers
{
    public class GolfCoursesController : ApiController
    {
        private GolfCourseContext db = new GolfCourseContext();

        // GET: api/GolfCourses
        public IQueryable<GolfCourse> GetGolfCourses()
        {
            return db.GolfCourses;
        }

        // GET: api/GolfCourses/5
        [ResponseType(typeof(GolfCourse))]
        public IHttpActionResult GetGolfCourse(int id)
        {
            GolfCourse golfCourse = db.GolfCourses.Find(id);
            if (golfCourse == null)
            {
                return NotFound();
            }

            return Ok(golfCourse);
        }

        // PUT: api/GolfCourses/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGolfCourse(int id, GolfCourse golfCourse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != golfCourse.Id)
            {
                return BadRequest();
            }

            db.Entry(golfCourse).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GolfCourseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/GolfCourses
        [ResponseType(typeof(GolfCourse))]
        public IHttpActionResult PostGolfCourse(GolfCourse golfCourse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GolfCourses.Add(golfCourse);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = golfCourse.Id }, golfCourse);
        }

        // DELETE: api/GolfCourses/5
        [ResponseType(typeof(GolfCourse))]
        public IHttpActionResult DeleteGolfCourse(int id)
        {
            GolfCourse golfCourse = db.GolfCourses.Find(id);
            if (golfCourse == null)
            {
                return NotFound();
            }

            db.GolfCourses.Remove(golfCourse);
            db.SaveChanges();

            return Ok(golfCourse);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GolfCourseExists(int id)
        {
            return db.GolfCourses.Count(e => e.Id == id) > 0;
        }
    }
}