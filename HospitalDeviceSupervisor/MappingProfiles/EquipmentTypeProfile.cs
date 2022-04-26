using AutoMapper;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.MappingProfiles;

public class EquipmentTypeProfile : Profile
{
    public EquipmentTypeProfile()
    {
        CreateMap<EquipmentType, EquipmentTypeDto>();
        CreateMap<EquipmentTypeDto, EquipmentType>()
            .ForMember(c => c.Id, opt => opt.Ignore()); ;
    }
}