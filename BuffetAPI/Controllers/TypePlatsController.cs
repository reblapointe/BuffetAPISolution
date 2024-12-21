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
    public class TypePlatsController(BuffetAPIContext context) : ControllerBase
    {
        private readonly BuffetAPIContext _context = context;

        // GET: api/TypePlats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypePlat>>> GetTypePlat()
        {
            return await _context.TypePlats.ToListAsync();
        }

        // GET: api/TypePlats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypePlat>> GetTypePlat(int id)
        {
            var typePlat = await _context.TypePlats.FindAsync(id);

            if (typePlat == null)
            {
                return NotFound();
            }

            return typePlat;
        }
    }
}
