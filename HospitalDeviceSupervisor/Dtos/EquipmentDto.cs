using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Dtos
{
    public class EquipmentDto
    {
        [Key]
        public int Id { get; set; }

        public string Maker { get; set; } = null!;

        public string Model { get; set; } = null!;

        public EquipmentTypeDto EquipmentType { get; set; } = null!;

        public DepartmentDto Department { get; set; } = null!;

        public LocationDto? Location { get; set; }

        public PersonDto? ResponsiblePerson { get; set; }

        public PersonDto? User { get; set; }

        public string InventoryNumber { get; set; } = null!;

        public string SerialNumber { get; set; } = null!;

        public EquipmentStateDto EquipmentState { get; set; } = null!;

        public bool IsRequiredRepair { get; set; } = false;

        public bool IsCurrentlyInUse { get; set; } = true;

        public ServiceCompanyDto? ServiceCompany { get; set; }

        public ThirdPartyPersonDto? ServiceEngineer { get; set; }
    }
}
