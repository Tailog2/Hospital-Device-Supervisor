#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalDeviceSupervisor.Data;
using HospitalDeviceSupervisor.Models;
using AutoMapper;
using HospitalDeviceSupervisor.Dtos;

namespace HospitalDeviceSupervisor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceCompaniesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public ServiceCompaniesController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        // GET: api/ServiceCompanies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceCompanyDto>>> GetServiceCompanies(string query = null)
        {
            var serviceCompanies = await _dbContext.ServiceCompanies
                .ToListAsync();

            if (!string.IsNullOrWhiteSpace(query))
                serviceCompanies = serviceCompanies.Where(sc => sc.Name.Contains(query)).ToList();

            var serviceCompanyDtos = serviceCompanies
                .Select(_mapper.Map<ServiceCompany, ServiceCompanyDto>)
                .ToList();

            return serviceCompanyDtos;
        }

        // GET: api/ServiceCompanies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceCompanyDto>> GetServiceCompany(int id)
        {
            var serviceCompany = await _dbContext.ServiceCompanies
                .Include(p => p.Workers)
                .SingleOrDefaultAsync(p => p.Id == id);

            if (serviceCompany is null)
                return NotFound();

            return _mapper.Map<ServiceCompany, ServiceCompanyDto>(serviceCompany);
        }

        // PUT: api/ServiceCompanies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceCompany(int id, ServiceCompanyDto serviceCompanyDto)
        {
            if (id != serviceCompanyDto.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return ValidationProblem();

            var serviceCompany = _mapper.Map<ServiceCompanyDto, ServiceCompany>(serviceCompanyDto);

            _dbContext.Entry(serviceCompany).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceCompanyExists(id))
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

        // POST: api/ServiceCompanies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ServiceCompanyDto>> PostServiceCompany(ServiceCompanyDto serviceCompanyDto)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            var serviceCompany = _mapper.Map<ServiceCompanyDto, ServiceCompany>(serviceCompanyDto);

            _dbContext.ServiceCompanies.Add(serviceCompany);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ServiceCompanyExists(serviceCompany.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(
                nameof(GetServiceCompany),
                new { id = serviceCompany.Id },
                serviceCompanyDto);
        }

        // DELETE: api/ServiceCompanies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceCompany(int id)
        {
            var serviceCompany = await _dbContext.ServiceCompanies.FindAsync(id);

            if (serviceCompany == null)
                return NotFound();

            _dbContext.ServiceCompanies.Remove(serviceCompany);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool ServiceCompanyExists(int id)
        {
            return _dbContext.ServiceCompanies.Any(e => e.Id == id);
        }
    }
}
