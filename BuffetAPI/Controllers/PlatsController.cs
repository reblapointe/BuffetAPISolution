using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BuffetAPI.Data;
using BuffetAPI.Models;

namespace BuffetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatsController(BuffetAPIContext context) : ControllerBase
    {
        private readonly BuffetAPIContext _context = context;

        // GET: api/Plats/citation
        [HttpGet("citation")]
        public ActionResult<string> GetCitation()
        {
            return Ok("Bienvenue au buffet!");
        }

        // GET: api/Plats/favori
        [HttpGet("favori")]
        public async Task<ActionResult<Plat>> GetFavori()
        {
            var plat = await _context.Plat.FindAsync(2);

            if (plat == null)
            {
                return NotFound();
            }

            return plat;
        }


        // GET: api/Plats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Plat>>> GetPlat()
        {
            return await _context.Plat.ToListAsync();
        }

        // GET: api/Plats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Plat>> GetPlat(int id)
        {
            var plat = await _context.Plat.Include(p => p.TypePlat).FirstOrDefaultAsync(p => p.Id == id);

            if (plat == null)
            {
                return NotFound();
            }

            return plat;
        }

        // PUT: api/Plats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlat(int id, Plat plat)
        {
            if (id != plat.Id)
            {
                return BadRequest();
            }

            var typePlat = await _context.TypePlat.FindAsync(plat.TypePlatId);
            if (typePlat == null)
            {
                return NotFound($"Le type de plat #{plat.TypePlatId} n'existe pas.");

            }
            plat.TypePlat = typePlat;
            _context.Entry(plat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlatExists(id))
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

        // POST: api/Plats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Plat>> PostPlat(Plat plat)
        {
            var typePlat = await _context.TypePlat.FindAsync(plat.TypePlatId);
            if (typePlat == null)
            {
                return NotFound($"Le type de plat #{plat.TypePlatId} n'existe pas.");

            }
            plat.TypePlat = typePlat;
            _context.Plat.Add(plat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlat", new { id = plat.Id }, plat);
        }

        // DELETE: api/Plats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlat(int id)
        {
            var plat = await _context.Plat.FindAsync(id);
            if (plat == null)
            {
                return NotFound();
            }

            _context.Plat.Remove(plat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlatExists(int id)
        {
            return _context.Plat.Any(e => e.Id == id);
        }
    }
}
