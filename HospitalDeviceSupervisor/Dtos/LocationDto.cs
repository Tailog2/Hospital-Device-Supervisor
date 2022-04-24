using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class LocationDto
{
    [Key]
    public int Id { get; set; }

    public BuildingDto Building { get; set; } = null!;

    public RoomDto Room { get; set; } = null!;
}