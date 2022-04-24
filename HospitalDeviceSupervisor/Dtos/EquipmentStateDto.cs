using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class EquipmentStateDto
{
    [Key]
    public byte Id { get; set; }

    [StringLength(20)]
    public string Name { get; set; } = null!;
}