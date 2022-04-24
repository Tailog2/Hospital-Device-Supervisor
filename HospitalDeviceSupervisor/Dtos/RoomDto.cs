using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class RoomDto
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)] 
    public string RoomName { get; set; } = null!;
}