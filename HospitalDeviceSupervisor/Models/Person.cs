using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper.Configuration.Annotations;
using Microsoft.EntityFrameworkCore;

namespace HospitalDeviceSupervisor.Models;

public class Person
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LustName { get; set; }

    public string? PatronymicName { get; set; }

    public int DepartmentId { get; set; }

    public Department Department { get; set; } = null!;

    public Position? Position { get; set; }

    public string? PhoneNumber { get; set; }

    public IEnumerable<Equipment>? Equipments { get; set; }
}