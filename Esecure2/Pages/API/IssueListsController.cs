using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Issues;

namespace EsecureWebApp.Pages.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueListsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public IssueListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/IssueLists
        [HttpGet]
        public IEnumerable<IssueList> GetIssueList()
        {
            return _context.IssueList;
        }

        // GET: api/IssueLists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetIssueList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var issueList = await _context.IssueList.FindAsync(id);

            if (issueList == null)
            {
                return NotFound();
            }

            return Ok(issueList);
        }

        // PUT: api/IssueLists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIssueList([FromRoute] int id, [FromBody] IssueList issueList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != issueList.IssueListId)
            {
                return BadRequest();
            }

            _context.Entry(issueList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IssueListExists(id))
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

        // POST: api/IssueLists
        [HttpPost]
        public async Task<IActionResult> PostIssueList([FromBody] IssueList issueList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.IssueList.Add(issueList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIssueList", new { id = issueList.IssueListId }, issueList);
        }

        // DELETE: api/IssueLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIssueList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var issueList = await _context.IssueList.FindAsync(id);
            if (issueList == null)
            {
                return NotFound();
            }

            _context.IssueList.Remove(issueList);
            await _context.SaveChangesAsync();

            return Ok(issueList);
        }

        private bool IssueListExists(int id)
        {
            return _context.IssueList.Any(e => e.IssueListId == id);
        }
    }
}