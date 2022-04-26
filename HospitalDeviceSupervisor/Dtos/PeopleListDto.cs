namespace HospitalDeviceSupervisor.Dtos
{
    public class PeopleListDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string? LastName { get; set; }

        public string? PatronymicName { get; set; }

        public DepartmentDto Department { get; set; } = null!;

        public PositionDto? Position { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
