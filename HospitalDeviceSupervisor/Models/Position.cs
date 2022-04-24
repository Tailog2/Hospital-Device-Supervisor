using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models;

public class Position
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public IEnumerable<Person>? Persons { get; set; }
}