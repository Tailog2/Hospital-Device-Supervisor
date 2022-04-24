using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models;

public class EquipmentType
{
    [Key]
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public IEnumerable<Equipment>? Equipments { get; set; }
}