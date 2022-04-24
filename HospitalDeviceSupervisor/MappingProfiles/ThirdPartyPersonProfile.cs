using AutoMapper;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.MappingProfiles;

public class ThirdPartyPersonProfile : Profile
{
    public ThirdPartyPersonProfile()
    {
        CreateMap<ThirdPartyPerson, ThirdPartyPersonDto>();
        CreateMap<ThirdPartyPersonDto, ThirdPartyPerson>();
    }
}