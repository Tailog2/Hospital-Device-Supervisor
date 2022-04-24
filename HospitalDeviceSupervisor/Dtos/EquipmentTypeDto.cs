namespace HospitalDeviceSupervisor.Dtos;

public class EquipmentTypeDto
{
    public short Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}