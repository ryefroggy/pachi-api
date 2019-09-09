using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PachiMaze.AspNetCore.NewDb.Models;
using PachiMaze.Models;

namespace PachiMaze.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoresController : ControllerBase
    {
        private readonly PachiContext _context;

        public ScoresController(PachiContext context)
        {
            _context = context;
        }

        // Get all scores
        // GET: api/Scores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Score>>> GetScore()
        {
            return await _context.Score
                .FromSql("SELECT * FROM \"Score\" ORDER BY \"Value\" DESC")
                .ToListAsync();
        }

        // Get scores for a specific user
        // GET: api/Scores/5
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<Score>>> GetScore(int userId)
        {
            return await _context.Score
                .FromSql($"SELECT * FROM \"Score\" WHERE UserId = {userId} ORDER BY \"Value\" DESC")
                .ToListAsync();
        }

        // POST: api/Scores/5
        [HttpPost("{userId}")]
        public async Task<ActionResult<Score>> PostScore(int userId, int value)
        {
            Score score = new Score(){ UserId = userId, Value = value, Time = DateTime.Now };
            
            _context.Score.Add(score);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScore", new { value = score.Value }, score);
        }
    }
}
