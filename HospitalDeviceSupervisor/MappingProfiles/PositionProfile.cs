    using AutoMapper;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.MappingProfiles;

public class PositionProfile : Profile
{
    public PositionProfile()
    {
        CreateMap<Position, PositionDto>();
        CreateMap<PositionDto, Position>();
    }
}