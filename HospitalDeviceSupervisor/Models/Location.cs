using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models;

public class Location
{
    public int Id { get; set; }

    public Building Building { get; set; } = null!;

    public IEnumerable<Room> Rooms { get; set; } = null!;

    public IEnumerable<Department> Department { get; set; } = null!;

    public IEnumerable<Equipment>? Equipments { get; set; }
}