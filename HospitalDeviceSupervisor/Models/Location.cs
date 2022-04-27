using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models;

public class Location
{
    public int Id { get; set; }

    public Building Building { get; set; } = null!;

    public Room Room { get; set; } = null!;

    public IEnumerable<Department> Departments { get; set; } = null!;

    public IEnumerable<Equipment>? Equipments { get; set; }
}