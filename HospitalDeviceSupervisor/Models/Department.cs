using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HospitalDeviceSupervisor.Models;

public class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DepartmentHeadId { get; set; }
    public Person DepartmentHead { get; set; } = null!;

    public IEnumerable<Person> Workers { get; set; } = null!;

    public int? SubDepartmentId { get; set; }
    public Department? SubDepartment { get; set; }

    public int? UpperDepartmentId { get; set; }
    public Department? UpperDepartment { get; set; }

    public IEnumerable<Equipment> Equipments { get; set; } = null!;
    public IEnumerable<Location> DepartmentLocations { get; set; } = null!;
}