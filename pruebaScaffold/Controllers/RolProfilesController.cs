using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pruebaScaffold.Models;

namespace pruebaScaffold.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolProfilesController : ControllerBase
    {
        private readonly TMConsultingContext _context;

        public RolProfilesController(TMConsultingContext context)
        {
            _context = context;
        }

        // GET: api/RolProfiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RolProfile>>> GetRolProfiles()
        {
            return await _context.RolProfiles.ToListAsync();
        }

        // GET: api/RolProfiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RolProfile>> GetRolProfile(int id)
        {
            var rolProfile = await _context.RolProfiles.FindAsync(id);

            if (rolProfile == null)
            {
                return NotFound();
            }

            return rolProfile;
        }

        // PUT: api/RolProfiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRolProfile(int id, RolProfile rolProfile)
        {
            if (id != rolProfile.RpId)
            {
                return BadRequest();
            }

            _context.Entry(rolProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RolProfileExists(id))
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

        // POST: api/RolProfiles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RolProfile>> PostRolProfile(RolProfile rolProfile)
        {
            _context.RolProfiles.Add(rolProfile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRolProfile", new { id = rolProfile.RpId }, rolProfile);
        }

        // DELETE: api/RolProfiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRolProfile(int id)
        {
            var rolProfile = await _context.RolProfiles.FindAsync(id);
            if (rolProfile == null)
            {
                return NotFound();
            }

            _context.RolProfiles.Remove(rolProfile);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RolProfileExists(int id)
        {
            return _context.RolProfiles.Any(e => e.RpId == id);
        }
    }
}
