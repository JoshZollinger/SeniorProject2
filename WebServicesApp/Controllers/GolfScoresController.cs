using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using App2.Models;
using WebServicesApp.Models;

namespace WebServicesApp.Controllers
{
    public class GolfScoresController : ApiController
    {
        private GolfScoreContext db = new GolfScoreContext();

        // GET: api/GolfScores
        public IQueryable<GolfScore> GetGolfScore()
        {
            return db.GolfScore;
        }

        // GET: api/GolfScores/5
        [ResponseType(typeof(GolfScore))]
        public async Task<IHttpActionResult> GetGolfScore(int id)
        {
            GolfScore golfScore = await db.GolfScore.FindAsync(id);
            if (golfScore == null)
            {
                return NotFound();
            }

            return Ok(golfScore);
        }

        // PUT: api/GolfScores/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGolfScore(int id, GolfScore golfScore)
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
                await db.SaveChangesAsync();
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
        public async Task<IHttpActionResult> PostGolfScore(GolfScore golfScore)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GolfScore.Add(golfScore);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = golfScore.Id }, golfScore);
        }

        // DELETE: api/GolfScores/5
        [ResponseType(typeof(GolfScore))]
        public async Task<IHttpActionResult> DeleteGolfScore(int id)
        {
            GolfScore golfScore = await db.GolfScore.FindAsync(id);
            if (golfScore == null)
            {
                return NotFound();
            }

            db.GolfScore.Remove(golfScore);
            await db.SaveChangesAsync();

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
            return db.GolfScore.Count(e => e.Id == id) > 0;
        }
    }
}