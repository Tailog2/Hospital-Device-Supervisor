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
    public class PeopleController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public PeopleController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        // GET: api/People
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeopleListDto>>> GetPersons(string queryFirstName = null, string queryLastName = null, string queryPatronymicName = null)
        {
            var people = await _dbContext.People
                .Include(p => p.Department)
                .Include(p => p.Position)
                .ToListAsync();

            if (!string.IsNullOrWhiteSpace(queryFirstName))
                people =  people.Where(p => p.FirstName.Contains(queryFirstName)).ToList();    
            
            if (!string.IsNullOrWhiteSpace(queryLastName))
                people = people.Where(p => p.FirstName.Contains(queryLastName)).ToList();

            if (!string.IsNullOrWhiteSpace(queryPatronymicName))
                people = people.Where(p => p.FirstName.Contains(queryPatronymicName)).ToList();

            var peopleListDto = people
                .Select(_mapper.Map<Person, PeopleListDto>)
                .ToList();

            return peopleListDto;
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDto>> GetPerson(int id)
        {
            var person = await _dbContext.People
                .Include(p => p.Department)
                .Include(p => p.Position)
                .SingleOrDefaultAsync(p => p.Id == id);

            if (person is null)
                return NotFound();

            return _mapper.Map<Person, PersonDto>(person);
        }

        // PUT: api/People/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson(int id, PersonDto personDto)
        {
            if (id != personDto.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return ValidationProblem();

            var person = _mapper.Map<PersonDto, Person>(personDto);

            _dbContext.Entry(person).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
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

        // POST: api/People
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonDto>> PostPerson(PersonDto personDto)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            var person = _mapper.Map<PersonDto, Person>(personDto);

            _dbContext.People.Add(person);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PersonExists(person.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(
                nameof(GetPerson),
                new { id = person.Id },
                personDto);
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            var person = await _dbContext.People.FindAsync(id);

            if (person == null)
                return NotFound();

            _dbContext.People.Remove(person);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonExists(int id)
        {
            return _dbContext.People.Any(e => e.Id == id);
        }
    }
}
