using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class PositionDto
{
    [Key]
    public short Id { get; set; }

    [StringLength(40)] 
    public string Name { get; set; } = null!;
}