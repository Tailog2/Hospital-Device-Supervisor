using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models;

public class Room
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public IEnumerable<Location> Locations { get; set; } = null!;
}