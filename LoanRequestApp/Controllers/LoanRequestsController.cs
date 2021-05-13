using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoanRequestApp.Models;

namespace LoanRequestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanRequestsController : ControllerBase
    {
        private readonly LoansDbContext _context;

        public LoanRequestsController(LoansDbContext context)
        {
            _context = context;
        }

        // GET: api/LoanRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoanRequest>>> GetLoanRequests()
        {
            return await _context.LoanRequests.ToListAsync();
        }

        // GET: api/LoanRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoanRequest>> GetLoanRequest(int id)
        {
            var loanRequest = await _context.LoanRequests.FindAsync(id);

            if (loanRequest == null)
            {
                return NotFound();
            }

            return loanRequest;
        }

        // PUT: api/LoanRequests/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoanRequest(int id, LoanRequest loanRequest)
        {
            if (id != loanRequest.LoanRequestId)
            {
                return BadRequest();
            }

            _context.Entry(loanRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoanRequestExists(id))
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

        // POST: api/LoanRequests
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LoanRequest>> PostLoanRequest(LoanRequest loanRequest)
        {
            _context.LoanRequests.Add(loanRequest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoanRequest", new { id = loanRequest.LoanRequestId }, loanRequest);
        }

        // DELETE: api/LoanRequests/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LoanRequest>> DeleteLoanRequest(int id)
        {
            var loanRequest = await _context.LoanRequests.FindAsync(id);
            if (loanRequest == null)
            {
                return NotFound();
            }

            _context.LoanRequests.Remove(loanRequest);
            await _context.SaveChangesAsync();

            return loanRequest;
        }

        private bool LoanRequestExists(int id)
        {
            return _context.LoanRequests.Any(e => e.LoanRequestId == id);
        }
    }
}
