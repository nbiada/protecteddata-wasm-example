using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProtectedDataWasmExample.Server.Data;
using ProtectedDataWasmExample.Server.Models;

namespace ProtectedDataWasmExample.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CompanyController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _context.Companies.ToListAsync();
            return Ok(companies);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetCompany(Guid id)
        {
            var company = await _context.Companies.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return Ok(company);
        }
    }
}
