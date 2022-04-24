using AutoMapper;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.MappingProfiles;

public class LocationProfile : Profile
{
    public LocationProfile()
    {
        CreateMap<Location, LocationDto>();
        CreateMap<LocationDto, Location>();
    }
}