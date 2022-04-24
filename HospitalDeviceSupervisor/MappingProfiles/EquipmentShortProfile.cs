using AutoMapper;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.MappingProfiles;

public class EquipmentShortProfile : Profile
{
    public EquipmentShortProfile()
    {
        CreateMap<EquipmentShort, EquipmentShortDto>();
        CreateMap<EquipmentShortDto, EquipmentShort>();
    }
}