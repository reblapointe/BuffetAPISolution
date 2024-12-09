using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BuffetAPI.Data;
using Microsoft.AspNetCore.Authorization;

namespace BuffetAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TypePlatsController : ControllerBase
    {
        private readonly BuffetAPIContext _context;

        public TypePlatsController(BuffetAPIContext context)
        {
            _context = context;
        }

        // GET: api/TypePlats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypePlat>>> GetTypePlat()
        {
            return await _context.TypePlat.ToListAsync();
        }

        // GET: api/TypePlats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypePlat>> GetTypePlat(int id)
        {
            var typePlat = await _context.TypePlat.FindAsync(id);

            if (typePlat == null)
            {
                return NotFound();
            }

            return typePlat;
        }
    }
}
