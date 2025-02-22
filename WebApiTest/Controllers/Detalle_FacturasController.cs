using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTest.Context;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Detalle_FacturasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public Detalle_FacturasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Detalle_Facturas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalle_Facturas>>> GetDETALLE_FACTURAS()
        {
            return await _context.DETALLE_FACTURAS.ToListAsync();
        }

        // GET: api/Detalle_Facturas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Detalle_Facturas>> GetDetalle_Facturas(int id)
        {
            var detalle_Facturas = await _context.DETALLE_FACTURAS.FindAsync(id);

            if (detalle_Facturas == null)
            {
                return NotFound();
            }

            return detalle_Facturas;
        }

        // PUT: api/Detalle_Facturas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalle_Facturas(int id, Detalle_Facturas detalle_Facturas)
        {
            if (id != detalle_Facturas.Id)
            {
                return BadRequest();
            }

            _context.Entry(detalle_Facturas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Detalle_FacturasExists(id))
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

        // POST: api/Detalle_Facturas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Detalle_Facturas>> PostDetalle_Facturas(Detalle_Facturas detalle_Facturas)
        {
            _context.DETALLE_FACTURAS.Add(detalle_Facturas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalle_Facturas", new { id = detalle_Facturas.Id }, detalle_Facturas);
        }

        // DELETE: api/Detalle_Facturas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalle_Facturas(int id)
        {
            var detalle_Facturas = await _context.DETALLE_FACTURAS.FindAsync(id);
            if (detalle_Facturas == null)
            {
                return NotFound();
            }

            _context.DETALLE_FACTURAS.Remove(detalle_Facturas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Detalle_FacturasExists(int id)
        {
            return _context.DETALLE_FACTURAS.Any(e => e.Id == id);
        }
    }
}
