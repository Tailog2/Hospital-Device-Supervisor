using System.ComponentModel.DataAnnotations;

namespace HospitalDeviceSupervisor.Models
{
    public class EquipmentShort
    {
        public int Id { get; set; }

        public string Maker { get; set; } = null!;

        public string Model { get; set; } = null!;

        public EquipmentType EquipmentType { get; set; } = null!;

        public Department Department { get; set; } = null!;

        public string InventoryNumber { get; set; } = null!;

        public EquipmentState EquipmentState { get; set; } = null!;

        public bool IsRequiredRepair { get; set; } = false;

        public bool IsCurrentlyInUse { get; set; } = true;

        public ObtainingType ObtainingType { get; set; } = null!;
    }
}
