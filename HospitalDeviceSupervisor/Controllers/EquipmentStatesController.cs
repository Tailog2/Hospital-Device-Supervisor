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
    public class EquipmentStatesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public EquipmentStatesController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        // GET: api/EquipmentStates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipmentStateDto>>> GetEquipmentStates(string? query = null)
        {
            IEnumerable<EquipmentState> equipmentStatesInDb;

            if (!string.IsNullOrWhiteSpace(query))
                equipmentStatesInDb = await _dbContext.EquipmentStates.Where(et => et.Name.Contains(query)).ToListAsync();
            else
                equipmentStatesInDb = await _dbContext.EquipmentStates.ToListAsync();

            var equipmentStatesDto = equipmentStatesInDb
                .Select(_mapper.Map<EquipmentState, EquipmentStateDto>)
                .ToList();

            return equipmentStatesDto;
        }

        // GET: api/EquipmentStates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EquipmentStateDto>> GetEquipmentState(byte id)
        {
            var equipmentStatesInDb = await _dbContext.EquipmentStates.SingleOrDefaultAsync(et => et.Id == id);

            if (equipmentStatesInDb is null)
                return NotFound();

            return _mapper.Map<EquipmentState, EquipmentStateDto>(equipmentStatesInDb);
        }

        // PUT: api/EquipmentStates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipmentState(byte id, EquipmentStateDto equipmentStateDto)
        {
            if (id != equipmentStateDto.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return ValidationProblem();

            var equipmentStateInDb = _mapper.Map<EquipmentStateDto, EquipmentState>(equipmentStateDto);

            _dbContext.Entry(equipmentStateInDb).State = EntityState.Modified;         

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipmentStateExists(id))
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

        // POST: api/EquipmentStates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EquipmentState>> PostEquipmentState(EquipmentStateDto equipmentStateDto)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            var equipmentState = _mapper.Map<EquipmentStateDto, EquipmentState>(equipmentStateDto);

            _dbContext.EquipmentStates.Add(equipmentState);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EquipmentStateExists(equipmentState.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(
                nameof(GetEquipmentState),
                new { id = equipmentState.Id },
                equipmentState);
        }

        // DELETE: api/EquipmentStates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquipmentState(byte id)
        {
            var equipmentStateInDb = await _dbContext.EquipmentStates.FindAsync(id);
            if (equipmentStateInDb == null)
                return NotFound();

            _dbContext.EquipmentStates.Remove(equipmentStateInDb);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool EquipmentStateExists(byte id)
        {
            return _dbContext.EquipmentStates.Any(e => e.Id == id);
        }
    }
}
