using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class ThirdPartyPersonDto
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string? LustName { get; set; }

    [StringLength(50)]
    public string? PatronymicName { get; set; }

    public PositionDto? Position { get; set; }

    [StringLength(20)]
    public string? PhoneNumber { get; set; }
}