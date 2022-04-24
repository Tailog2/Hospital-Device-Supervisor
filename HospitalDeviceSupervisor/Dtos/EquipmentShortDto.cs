namespace HospitalDeviceSupervisor.Dtos
{
    public class EquipmentShortDto
    {
        public int Id { get; set; }

        public string Maker { get; set; } = null!;

        public string Model { get; set; } = null!;

        public EquipmentTypeDto EquipmentType { get; set; } = null!;

        public DepartmentDto Department { get; set; } = null!;

        public string InventoryNumber { get; set; } = null!;

        public string SerialNumber { get; set; } = null!;

        public EquipmentStateDto EquipmentState { get; set; } = null!;

        public bool IsRequiredRepair { get; set; } = false;

        public bool IsCurrentlyInUse { get; set; } = true;
    }
}
