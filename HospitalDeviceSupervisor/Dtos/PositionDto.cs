using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class PositionDto
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;
}