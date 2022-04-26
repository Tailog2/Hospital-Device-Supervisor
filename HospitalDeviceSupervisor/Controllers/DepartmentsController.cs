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
    public class DepartmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public DepartmentsController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        // GET: api/Departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentsListDto>>> GetDepartments(string query = null)
        {
            IEnumerable<Department> departments;

            if (!string.IsNullOrWhiteSpace(query))
                departments = await _dbContext.Departments
                    .Include(d => d.DepartmentHead)
                    .Where(et => et.Name.Contains(query))
                    .ToListAsync();
            else
                departments = await _dbContext.Departments
                    .Include(d => d.DepartmentHead)
                    .ToListAsync();

            var departmentsDto = departments
                .Select(_mapper.Map<Department, DepartmentsListDto>)
                .ToList();

            return departmentsDto;
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentDto>> GetDepartment(int id)
        {
            var department = await _dbContext.Departments
                .Include(d => d.DepartmentHead)
                .Include(d => d.SubDepartment)
                .Include(d => d.UpperDepartment)
                .Include(d => d.Workers)
                .Include(d => d.DepartmentLocations)
                .Include(d => d.Equipments)
                .SingleOrDefaultAsync(d => d.Id == id);

            if (department is null)
                return NotFound();

            return _mapper.Map<Department, DepartmentDto>(department);
        }

        // PUT: api/Departments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment(int id, DepartmentDto departmentDto)
        {
            if (id != departmentDto.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return ValidationProblem();

            var department = _mapper.Map<DepartmentDto, Department>(departmentDto);

            _dbContext.Entry(department).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
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

        // POST: api/Departments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Department>> PostDepartment(DepartmentDto departmentDto)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            var department = _mapper.Map<DepartmentDto, Department>(departmentDto);

            _dbContext.Departments.Add(department);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DepartmentExists(department.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(
                nameof(GetDepartment),
                new { id = department.Id },
                department);
        }

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var department = await _dbContext.Departments.FindAsync(id);

            if (department == null)
                return NotFound();

            _dbContext.Departments.Remove(department);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool DepartmentExists(int id)
        {
            return _dbContext.Departments.Any(e => e.Id == id);
        }
    }
}
