using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos;

public class DepartmentDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public PersonDto DepartmentHead { get; set; } = null!;

    public DepartmentDto? SubDepartment { get; set; }

    public DepartmentDto? SuperiorDepartment { get; set; }

    public IEnumerable<LocationDto> DepartmentLocations { get; set; } = null!;
}