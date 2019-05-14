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
    public class GolfScoresController : ApiController
    {
        private GolfScoreContext db = new GolfScoreContext();

        // GET: api/GolfScores
        public IQueryable<GolfScore> GetGolfScores()
        {
            return db.GolfScores;
        }

        // GET: api/GolfScores/5
        [ResponseType(typeof(GolfScore))]
        public IHttpActionResult GetGolfScore(int id)
        {
            GolfScore golfScore = db.GolfScores.Find(id);
            if (golfScore == null)
            {
                return NotFound();
            }

            return Ok(golfScore);
        }

        // PUT: api/GolfScores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGolfScore(int id, GolfScore golfScore)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != golfScore.Id)
            {
                return BadRequest();
            }

            db.Entry(golfScore).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GolfScoreExists(id))
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

        // POST: api/GolfScores
        [ResponseType(typeof(GolfScore))]
        public IHttpActionResult PostGolfScore(GolfScore golfScore)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GolfScores.Add(golfScore);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = golfScore.Id }, golfScore);
        }

        // DELETE: api/GolfScores/5
        [ResponseType(typeof(GolfScore))]
        public IHttpActionResult DeleteGolfScore(int id)
        {
            GolfScore golfScore = db.GolfScores.Find(id);
            if (golfScore == null)
            {
                return NotFound();
            }

            db.GolfScores.Remove(golfScore);
            db.SaveChanges();

            return Ok(golfScore);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GolfScoreExists(int id)
        {
            return db.GolfScores.Count(e => e.Id == id) > 0;
        }
    }
}