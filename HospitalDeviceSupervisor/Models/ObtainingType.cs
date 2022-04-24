using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models;

public class ObtainingType
{
    public int Id { get; set; }
    public byte Name { get; set; }
    public IEnumerable<Equipment>? Equipment { get; set; }
}