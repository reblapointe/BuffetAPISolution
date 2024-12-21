using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BuffetAPI.Data;

namespace BuffetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatsController(BuffetAPIContext context, ILogger<PlatsController> logger) : ControllerBase
    {
        private readonly BuffetAPIContext _context = context;
        private readonly ILogger<PlatsController> _logger = logger;

        // GET: api/Plats/citation
        [HttpGet("citation")]
        public ActionResult<string> GetCitation()
        {
            _logger.LogInformation("On m'a demandé la citation");
            return Ok("Bienvenue au buffet!");
        }

        // POST: api/Plats/manger/id
        [HttpPost("manger/{id}")]
        public async Task<ActionResult<Plat>> Manger(int id)
        {
            var plat = await _context.Plat.FindAsync(id);

            if (plat == null || plat.Mange)
            {
                _logger.LogWarning("Le client a demandé le plat {id}, qui n'existe pas, ou qui a déjà été mangé.", id);
                return NotFound(new { Message = "Le plat demandé n'existe pas, ou a déjà été mangé." });
            }

            plat.Mange = true;
            await _context.SaveChangesAsync();

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
                _logger.LogWarning("Le client a demandé le type plat {Typeplat}, qui n'existe pas.", plat.TypePlatId);
                return NotFound($"Le type de plat #{plat.TypePlatId} n'existe pas.");

            }
            plat.TypePlat = typePlat;
            _context.Entry(plat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError("Exception {e}", ex.Message);
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
