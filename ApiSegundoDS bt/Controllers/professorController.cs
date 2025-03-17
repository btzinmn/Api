using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiSegundoDS_bt.Data;
using ApiSegundoDS_bt.models;

namespace ApiSegundoDS_bt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class professorController : ControllerBase
    {
        private readonly ApiSegundoDS_btContext _context;

        public professorController(ApiSegundoDS_btContext context)
        {
            _context = context;
        }

        // GET: api/professor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<professor>>> Getprofessor()
        {
            return await _context.professor.ToListAsync();
        }

        // GET: api/professor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<professor>> Getprofessor(int id)
        {
            var professor = await _context.professor.FindAsync(id);

            if (professor == null)
            {
                return NotFound();
            }

            return professor;
        }

        // PUT: api/professor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putprofessor(int id, professor professor)
        {
            if (id != professor.Id)
            {
                return BadRequest();
            }

            _context.Entry(professor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!professorExists(id))
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

        // POST: api/professor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<professor>> Postprofessor(professor professor)
        {
            _context.professor.Add(professor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getprofessor", new { id = professor.Id }, professor);
        }

        // DELETE: api/professor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteprofessor(int id)
        {
            var professor = await _context.professor.FindAsync(id);
            if (professor == null)
            {
                return NotFound();
            }

            _context.professor.Remove(professor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool professorExists(int id)
        {
            return _context.professor.Any(e => e.Id == id);
        }
    }
}
