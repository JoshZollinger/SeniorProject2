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
    public class GolfUsersController : ApiController
    {
        private GolfUserContext db = new GolfUserContext();

        // GET: api/GolfUsers
        public IQueryable<GolfUser> GetGolfUsers()
        {
            return db.GolfUsers;
        }

        // GET: api/GolfUsers/5
        [ResponseType(typeof(GolfUser))]
        public IHttpActionResult GetGolfUser(int id)
        {
            GolfUser golfUser = db.GolfUsers.Find(id);
            if (golfUser == null)
            {
                return NotFound();
            }

            return Ok(golfUser);
        }

        // PUT: api/GolfUsers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGolfUser(int id, GolfUser golfUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != golfUser.Id)
            {
                return BadRequest();
            }

            db.Entry(golfUser).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GolfUserExists(id))
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

        // POST: api/GolfUsers
        [ResponseType(typeof(GolfUser))]
        public IHttpActionResult PostGolfUser(GolfUser golfUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GolfUsers.Add(golfUser);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = golfUser.Id }, golfUser);
        }

        // DELETE: api/GolfUsers/5
        [ResponseType(typeof(GolfUser))]
        public IHttpActionResult DeleteGolfUser(int id)
        {
            GolfUser golfUser = db.GolfUsers.Find(id);
            if (golfUser == null)
            {
                return NotFound();
            }

            db.GolfUsers.Remove(golfUser);
            db.SaveChanges();

            return Ok(golfUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GolfUserExists(int id)
        {
            return db.GolfUsers.Count(e => e.Id == id) > 0;
        }
    }
}