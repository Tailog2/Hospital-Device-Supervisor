using AutoMapper;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.MappingProfiles;

public class PersonProfile : Profile
{
    public PersonProfile()
    {
        CreateMap<Person, PersonDto>();
        CreateMap<PersonDto, Person>();
    }
}