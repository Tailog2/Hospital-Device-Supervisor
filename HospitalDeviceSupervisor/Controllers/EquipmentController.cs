using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalDeviceSupervisor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipment>>> GetEquipmentList(string? query = null)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Equipment>> GetEquipment(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> CreateEquipment()
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Equipment>> CreateEquipment(int id, EquipmentDto equipmentDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> CreateEquipment(int id)
        {
            throw new NotImplementedException();
        }
    }
}
