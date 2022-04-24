using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class ServiceCompanyDto
{
    [Key] 
    public int Id { get; set; }

    [StringLength(50)] 
    public string Name { get; set; } = null!;

    [StringLength(20)]
    public string? PhoneNumber { get; set; }

    public IEnumerable<ThirdPartyPersonDto>? Workers { get; set; }
}