using AutoMapper;
using HospitalDeviceSupervisor.Dtos;
using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.MappingProfiles;

public class ServiceCompanyProfile : Profile
{
    public ServiceCompanyProfile()
    {
        CreateMap<ServiceCompany, ServiceCompanyDto>();
        CreateMap<ServiceCompanyDto, ServiceCompany>();
    }
}