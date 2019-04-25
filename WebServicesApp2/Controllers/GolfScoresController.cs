using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebServicesApp2.Models;

namespace WebServicesApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GolfScoresController : ControllerBase
    {
        private readonly GolfScoreContext _context;

        public GolfScoresController(GolfScoreContext context)
        {
            _context = context;
        }

        // GET: api/GolfScores
        [HttpGet]
        public IEnumerable<GolfScore> GetGolfScore()
        {
            return _context.GolfScore;
        }

        // GET: api/GolfScores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGolfScore([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var golfScore = await _context.GolfScore.FindAsync(id);

            if (golfScore == null)
            {
                return NotFound();
            }

            return Ok(golfScore);
        }

        // PUT: api/GolfScores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGolfScore([FromRoute] int id, [FromBody] GolfScore golfScore)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != golfScore.Id)
            {
                return BadRequest();
            }

            _context.Entry(golfScore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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

            return NoContent();
        }

        // POST: api/GolfScores
        [HttpPost]
        public async Task<IActionResult> PostGolfScore([FromBody] GolfScore golfScore)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.GolfScore.Add(golfScore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGolfScore", new { id = golfScore.Id }, golfScore);
        }

        // DELETE: api/GolfScores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGolfScore([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var golfScore = await _context.GolfScore.FindAsync(id);
            if (golfScore == null)
            {
                return NotFound();
            }

            _context.GolfScore.Remove(golfScore);
            await _context.SaveChangesAsync();

            return Ok(golfScore);
        }

        private bool GolfScoreExists(int id)
        {
            return _context.GolfScore.Any(e => e.Id == id);
        }
    }
}