using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartOut.Models;

namespace PartOut.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartOutItemController : ControllerBase
    {
        private readonly PartOutItemContext _context;

        public PartOutItemController(PartOutItemContext context)
        {
            _context = context;
        }

        // GET: api/PartOutItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PartOutItem>>> GetPartOutItems()
        {
            return await _context.PartOutItems.ToListAsync();
        }

        // GET: api/PartOutItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PartOutItem>> GetPartOutItem(long id)
        {
            var partOutItem = await _context.PartOutItems.FindAsync(id);

            if (partOutItem == null)
            {
                return NotFound();
            }

            return partOutItem;
        }

        // PUT: api/PartOutItem/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartOutItem(long id, PartOutItem partOutItem)
        {
            if (id != partOutItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(partOutItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartOutItemExists(id))
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

        // POST: api/PartOutItem
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PartOutItem>> PostPartOutItem(PartOutItem partOutItem)
        {
            _context.PartOutItems.Add(partOutItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPartOutItem), new { id = partOutItem.Id }, partOutItem);
        }

        // DELETE: api/PartOutItem/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PartOutItem>> DeletePartOutItem(long id)
        {
            var partOutItem = await _context.PartOutItems.FindAsync(id);
            if (partOutItem == null)
            {
                return NotFound();
            }

            _context.PartOutItems.Remove(partOutItem);
            await _context.SaveChangesAsync();

            return partOutItem;
        }

        private bool PartOutItemExists(long id)
        {
            return _context.PartOutItems.Any(e => e.Id == id);
        }
    }
}
