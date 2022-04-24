namespace HospitalDeviceSupervisor.Models;

public class Building
{
    public int Id { get; set; }

    public string BuildingName { get; set; } = null!;

    public IEnumerable<Location> Locations { get; set; } = null!;
}