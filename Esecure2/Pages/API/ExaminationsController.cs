using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Exam;

namespace EsecureWebApp.Pages.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExaminationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExaminationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Examinations
        [HttpGet]
        public IEnumerable<Examination> GetExamination()
        {
            return _context.Examination;
        }

        // GET: api/Examinations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExamination([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var examination = await _context.Examination.FindAsync(id);

            if (examination == null)
            {
                return NotFound();
            }

            return Ok(examination);
        }

        // PUT: api/Examinations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExamination([FromRoute] int id, [FromBody] Examination examination)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != examination.ExaminationID)
            {
                return BadRequest();
            }

            _context.Entry(examination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExaminationExists(id))
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

        // POST: api/Examinations
        [HttpPost]
        public async Task<IActionResult> PostExamination([FromBody] Examination examination)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Examination.Add(examination);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExamination", new { id = examination.ExaminationID }, examination);
        }

        // DELETE: api/Examinations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExamination([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var examination = await _context.Examination.FindAsync(id);
            if (examination == null)
            {
                return NotFound();
            }

            _context.Examination.Remove(examination);
            await _context.SaveChangesAsync();

            return Ok(examination);
        }

        private bool ExaminationExists(int id)
        {
            return _context.Examination.Any(e => e.ExaminationID == id);
        }
    }
}