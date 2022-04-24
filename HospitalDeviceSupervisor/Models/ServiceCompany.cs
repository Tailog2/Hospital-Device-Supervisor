using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models;

public class ServiceCompany
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public IEnumerable<Equipment>? Equipment { get; set; }

    public IEnumerable<ThirdPartyPerson>? Workers { get; set; }
}