using AutoMapper;
using HospitalDeviceSupervisor.Data;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HospitalDeviceSupervisor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentTypesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public EquipmentTypesController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        // GET: api/<EquipmentTypeController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipmentTypeDto>>> GetEquipmentTypes(string? query = null)
        {
            IEnumerable<EquipmentType> equipmentTypesInDb;

            if (!string.IsNullOrWhiteSpace(query))
                equipmentTypesInDb = await _dbContext.EquipmentTypes.Where(et => et.Name.Contains(query)).ToListAsync();
            else
                equipmentTypesInDb = await _dbContext.EquipmentTypes.ToListAsync();

            var equipmentTypesDto = equipmentTypesInDb
                .Select(_mapper.Map<EquipmentType, EquipmentTypeDto>).ToList();

            return equipmentTypesDto;
        }

        // GET api/<EquipmentTypeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EquipmentTypeDto>> GetEquipmentType(int id)
        {
            var equipmentTypeInDb = await _dbContext.EquipmentTypes.SingleOrDefaultAsync(et => et.Id == id);

            if (equipmentTypeInDb is null)
                return NotFound();

            return _mapper.Map<EquipmentType, EquipmentTypeDto>(equipmentTypeInDb);
        }

        // POST api/<EquipmentTypeController>
        [HttpPost]
        public async Task<ActionResult<EquipmentType>> PostEquipmentType(EquipmentTypeDto equipmentTypeDto)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            var equipmentType = _mapper.Map<EquipmentTypeDto, EquipmentType>(equipmentTypeDto);

            _dbContext.EquipmentTypes.Add(equipmentType);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EquipmentTypeExists(equipmentTypeDto.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(
                nameof(GetEquipmentType),
                new { id = equipmentType.Id },
                equipmentType);
        }

        // PUT api/<EquipmentTypeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipmentType(short id, EquipmentTypeDto equipmentTypeDto)
        {
            if (id != equipmentTypeDto.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return ValidationProblem();

            var equipmentTypeInDb = _mapper.Map<EquipmentTypeDto, EquipmentType>(equipmentTypeDto);

            _dbContext.Entry(equipmentTypeInDb).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipmentTypeExists(id))
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

        // DELETE api/<EquipmentTypeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquipmentType(int id)
        {
            var equipmentTypeInDb = await _dbContext.EquipmentTypes.FindAsync(id);
            if (equipmentTypeInDb == null)
                return NotFound();

            _dbContext.EquipmentTypes.Remove(equipmentTypeInDb);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool EquipmentTypeExists(short id)
        {
            return _dbContext.EquipmentTypes.Any(e => e.Id == id);
        }
    }
}
