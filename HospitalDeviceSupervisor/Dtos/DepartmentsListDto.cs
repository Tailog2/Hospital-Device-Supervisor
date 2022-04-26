using HospitalDeviceSupervisor.Models;

namespace HospitalDeviceSupervisor.Dtos
{
    public class DepartmentsListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Person DepartmentHead { get; set; } = null!;
    }
}
