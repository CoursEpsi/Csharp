using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mediatheque.Core.DAL;
using Mediatheque.Core.Model;

namespace Mediatheque.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CDController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CDController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CD
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CD>>> GetCDs()
        {
            return await _context.CDs.ToListAsync();
        }

        // GET: api/CD/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CD>> GetCD(int id)
        {
            var cD = await _context.CDs.FindAsync(id);

            if (cD == null)
            {
                return NotFound();
            }

            return cD;
        }

        // PUT: api/CD/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCD(int id, CD cD)
        {
            if (id != cD.Id)
            {
                return BadRequest();
            }

            _context.Entry(cD).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CDExists(id))
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

        // POST: api/CD
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CD>> PostCD(CD cD)
        {
            _context.CDs.Add(cD);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCD", new { id = cD.Id }, cD);
        }

        // DELETE: api/CD/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCD(int id)
        {
            var cD = await _context.CDs.FindAsync(id);
            if (cD == null)
            {
                return NotFound();
            }

            _context.CDs.Remove(cD);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CDExists(int id)
        {
            return _context.CDs.Any(e => e.Id == id);
        }
    }
}
