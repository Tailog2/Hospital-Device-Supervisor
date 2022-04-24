using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Maker { get; set; } = null!;
        public string Model { get; set; } = null!;
        public EquipmentType EquipmentType { get; set; } = null!;
        public Department Department { get; set; } = null!;
        public Location? Location { get; set; }
        public int? ResponsiblePersonId { get; set; }
        public Person? ResponsiblePerson { get; set; }
        public int? UserId { get; set; }
        public Person? User { get; set; }
        public string InventoryNumber { get; set; } = null!;
        public string SerialNumber { get; set; } = null!;
        public EquipmentState EquipmentState { get; set; } = null!;
        public bool IsRequiredRepair { get; set; } = false;
        public bool IsCurrentlyInUse { get; set; } = true;
        public ServiceCompany? ServiceCompany { get; set; }
        public ThirdPartyPerson? ServiceEngineer { get; set; }
        public ObtainingType ObtainingType { get; set; } = null!;
    }
}
