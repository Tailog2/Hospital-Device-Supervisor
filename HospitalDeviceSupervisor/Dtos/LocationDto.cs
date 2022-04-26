using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class LocationDto
{
    public int Id { get; set; }

    public BuildingDto Building { get; set; } = null!;

    public RoomDto Room { get; set; } = null!;
}