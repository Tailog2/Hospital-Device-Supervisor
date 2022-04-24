using AutoMapper;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.MappingProfiles;

public class BuildingProfile : Profile
{
    public BuildingProfile()
    {
        CreateMap<Building, BuildingDto>();
        CreateMap<BuildingDto, Building>();
    }
}