namespace HospitalDeviceSupervisor.Models;

public class Building
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public string? Name { get; set; }

    public IEnumerable<Location> Locations { get; set; } = null!;
}