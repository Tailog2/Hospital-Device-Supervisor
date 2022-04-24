using AutoMapper;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.MappingProfiles
{
    public class EquipmentProfile : Profile
    {
        public EquipmentProfile()
        {
            CreateMap<Equipment, EquipmentDto>();
            CreateMap<EquipmentDto, Equipment>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
