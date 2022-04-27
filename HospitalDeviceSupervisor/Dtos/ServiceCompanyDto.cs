using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class ServiceCompanyDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public IEnumerable<ThirdPartyPersonDto>? Workers { get; set; }
}