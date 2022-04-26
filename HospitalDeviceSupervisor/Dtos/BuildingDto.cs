using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class BuildingDto
{
    public int Id { get; set; }

    public int BuildingNumber { get; set; }

    [StringLength(50)]
    public string? BuildingName { get; set; }
}