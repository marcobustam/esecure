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
    public class IssueItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public IssueItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/IssueItems
        [HttpGet]
        public IEnumerable<IssueItem> GetIssueItem()
        {
            return _context.IssueItem;
        }

        // GET: api/IssueItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetIssueItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var issueItem = await _context.IssueItem.FindAsync(id);

            if (issueItem == null)
            {
                return NotFound();
            }

            return Ok(issueItem);
        }

        // PUT: api/IssueItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIssueItem([FromRoute] int id, [FromBody] IssueItem issueItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != issueItem.IssueItemID)
            {
                return BadRequest();
            }

            _context.Entry(issueItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IssueItemExists(id))
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

        // POST: api/IssueItems
        [HttpPost]
        public async Task<IActionResult> PostIssueItem([FromBody] IssueItem issueItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // .ListaIssues.Add(issueItem)
            // var List =
            _context.IssueList.Include(x => x.ListaIssues).Where(y => y.IssueListId == issueItem.IssueListId).First().ListaIssues.Add(issueItem);
            // _context.IssueItem.Add(issueItem);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetIssueItem", new { id = issueItem.IssueItemID }, issueItem);
        }

        // DELETE: api/IssueItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIssueItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var issueItem = await _context.IssueItem.FindAsync(id);
            if (issueItem == null)
            {
                return NotFound();
            }

            _context.IssueItem.Remove(issueItem);
            await _context.SaveChangesAsync();

            return Ok(issueItem);
        }

        private bool IssueItemExists(int id)
        {
            return _context.IssueItem.Any(e => e.IssueItemID == id);
        }
    }
}