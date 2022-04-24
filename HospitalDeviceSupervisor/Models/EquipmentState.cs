using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models;

public class EquipmentState
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public IEnumerable<Equipment>? Equipments { get; set; }
}