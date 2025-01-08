using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BuffetAPI.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using BuffetAPI.Models.Plats;
using AutoMapper;
using System.Diagnostics.Metrics;

namespace BuffetAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class PlatsController : ControllerBase
    {
        private readonly BuffetAPIContext _context;
        private readonly ILogger<PlatsController> _logger;
        private readonly IMapper _mapper;

        public PlatsController(BuffetAPIContext context, ILogger<PlatsController> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: api/Plats/citation
        [HttpGet("citation")]
        [AllowAnonymous]
        public ActionResult<string> GetCitation()
        {
            _logger.LogInformation("On m'a demandé la citation");
            return Ok("Bienvenue au buffet!");
        }

        // POST: api/Plats/manger/id
        [HttpPost("manger/{id}")]
        public async Task<ActionResult<DetailsPlatDTO>> Manger(int id)
        {
            try
            {
                var plat = await _context.Plat.FindAsync(id);

                if (plat == null)
                {
                    return NotFound(new { Message = "Le plat demandé n'existe pas." });
                }
                if (plat.Mange)
                {
                    return BadRequest(new { Message = "Le plat est déjà mangé." });
                }

                plat.Mange = true;
                plat.OgreId = GetUserName();

                await _context.SaveChangesAsync();

                _logger.LogInformation("{ogre} a mangé le plat #{id} : {nom}", plat.OgreId, id, plat.Nom);

                return _mapper.Map<DetailsPlatDTO>(plat);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError("Exception {e}", ex.Message);
                return StatusCode(500, new { Message = "Une erreur est survenue.", Error = ex.Message });
            }
        }


        // GET: api/Plats
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<GetPlatDTO>>> GetPlat()
        {
            var plats = await _context.Plat.ToListAsync();
            var platsDTO = _mapper.Map<List<GetPlatDTO>>(plats);
            return Ok(platsDTO);
        }

        // GET: api/Plats/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<DetailsPlatDTO>> GetPlat(int id)
        {
            var plat = await _context.Plat.Include(p => p.TypePlat).FirstOrDefaultAsync(p => p.Id == id);

            if (plat == null)
            {
                return NotFound();
            }

            return _mapper.Map<DetailsPlatDTO>(plat);
        }

        // PUT: api/Plats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Cuisinier,Administrateur")]
        public async Task<IActionResult> PutPlat(int id, PutPlatDTO platDto)
        {
            if (id != platDto.Id)
            {
                return BadRequest();
            }

            var plat = await _context.Plat.FindAsync(id);
            if (plat == null)
                return BadRequest();

            if (!HttpContext.User.IsInRole("Administrateur") &&
                (plat.CuisinierId == null || plat.CuisinierId != GetUserName()))
                return Unauthorized();


            var typePlat = await _context.TypePlat.FindAsync(platDto.TypePlatId);
            if (typePlat == null)
            {
                _logger.LogWarning("Le client a demandé le type plat {Typeplat}, qui n'existe pas.", platDto.TypePlatId);
                return NotFound($"Le type de plat #{platDto.TypePlatId} n'existe pas.");

            }
            if (!HttpContext.User.IsInRole("Administrateur"))
                platDto.CuisinierId = plat.CuisinierId;
            _mapper.Map(platDto, plat);

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
        [Authorize(Roles = "Cuisinier,Administrateur")]
        public async Task<ActionResult<DetailsPlatDTO>> PostPlat(PostPlatDTO platDto)
        {
            var plat = _mapper.Map<Plat>(platDto);
            plat.CuisinierId = GetUserName();
            if (plat.CuisinierId == null)
                return Unauthorized();

            var typePlat = await _context.TypePlat.FindAsync(plat.TypePlatId);
            if (typePlat == null)
            {
                return NotFound($"Le type de plat #{plat.TypePlatId} n'existe pas.");

            }
            plat.TypePlat = typePlat;
            plat.Mange = false;
            plat.OgreId = null;
            _context.Plat.Add(plat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlat", new { id = plat.Id }, _mapper.Map<DetailsPlatDTO>(plat));
        }

        // DELETE: api/Plats/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Cuisinier,Administrateur")]
        public async Task<IActionResult> DeletePlat(int id)
        {
            var plat = await _context.Plat.FindAsync(id);
            if (plat == null)
            {
                return NotFound();
            }
            if (!HttpContext.User.IsInRole("Administrateur") &&
                (plat.CuisinierId == null || plat.CuisinierId != GetUserName()))
                return Unauthorized();


            _context.Plat.Remove(plat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlatExists(int id)
        {
            return _context.Plat.Any(e => e.Id == id);
        }

        private string? GetUserName()
        {
            return HttpContext.User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
                       ?? HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
