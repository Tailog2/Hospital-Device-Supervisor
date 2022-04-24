using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration;

public class EquipmentTypeEntityTypeConfiguration : IEntityTypeConfiguration<EquipmentType>
{
    public void Configure(EntityTypeBuilder<EquipmentType> modelBuilder)
    {
        modelBuilder.HasKey(t => t.Id);

        modelBuilder.Property(t => t.Name).HasMaxLength(50);

        modelBuilder.Property(t => t.Description).HasMaxLength(2000);
    }
}

public class EquipmentStateEntityTypeConfiguration : IEntityTypeConfiguration<EquipmentState>
{
    public void Configure(EntityTypeBuilder<EquipmentState> modelBuilder)
    {
        modelBuilder.HasKey(t => t.Id);

        modelBuilder.Property(t => t.Name).HasMaxLength(50);

    }
}