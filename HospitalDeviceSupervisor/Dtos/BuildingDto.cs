using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class BuildingDto
{
    public int Id { get; set; }

    public int Number { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }
}