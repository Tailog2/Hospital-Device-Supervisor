using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models;

public class ThirdPartyPerson
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LustName { get; set; }

    public string? PatronymicName { get; set; }

    public string? Position { get; set; }

    public string? PhoneNumber { get; set; }

    public IEnumerable<Equipment>? Equipment { get; set; }

    public ServiceCompany? ServiceCompany { get; set; }
}