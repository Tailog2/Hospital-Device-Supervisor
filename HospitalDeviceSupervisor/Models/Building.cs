namespace HospitalDeviceSupervisor.Models;

public class Building
{
    public int Id { get; set; }

    public int Number { get; set; }

    public string? Name { get; set; }

    public IEnumerable<Location> Locations { get; set; } = null!;
}