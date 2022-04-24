using AutoMapper;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.MappingProfiles;

public class EquipmentStateProfile : Profile
{
    public EquipmentStateProfile()
    {
        CreateMap<EquipmentState, EquipmentStateDto>();
        CreateMap<EquipmentStateDto, EquipmentState>();
    }
}