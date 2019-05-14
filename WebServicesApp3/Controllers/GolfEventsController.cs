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
    public class GolfEventsController : ApiController
    {
        private GolfEventContext db = new GolfEventContext();

        // GET: api/GolfEvents
        public IQueryable<GolfEvent> GetGolfEvents()
        {
            return db.GolfEvents;
        }

        // GET: api/GolfEvents/5
        [ResponseType(typeof(GolfEvent))]
        public IHttpActionResult GetGolfEvent(int id)
        {
            GolfEvent golfEvent = db.GolfEvents.Find(id);
            if (golfEvent == null)
            {
                return NotFound();
            }

            return Ok(golfEvent);
        }

        // PUT: api/GolfEvents/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGolfEvent(int id, GolfEvent golfEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != golfEvent.Id)
            {
                return BadRequest();
            }

            db.Entry(golfEvent).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GolfEventExists(id))
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

        // POST: api/GolfEvents
        [ResponseType(typeof(GolfEvent))]
        public IHttpActionResult PostGolfEvent(GolfEvent golfEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GolfEvents.Add(golfEvent);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = golfEvent.Id }, golfEvent);
        }

        // DELETE: api/GolfEvents/5
        [ResponseType(typeof(GolfEvent))]
        public IHttpActionResult DeleteGolfEvent(int id)
        {
            GolfEvent golfEvent = db.GolfEvents.Find(id);
            if (golfEvent == null)
            {
                return NotFound();
            }

            db.GolfEvents.Remove(golfEvent);
            db.SaveChanges();

            return Ok(golfEvent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GolfEventExists(int id)
        {
            return db.GolfEvents.Count(e => e.Id == id) > 0;
        }
    }
}