using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration;

public class EquipmentEntityTypeConfiguration : IEntityTypeConfiguration<Equipment>
{
    public void Configure(EntityTypeBuilder<Equipment> modelBuilder)
    {
        modelBuilder.HasKey(e => e.Id);

        modelBuilder.Property(e => e.Maker).HasMaxLength(50);

        modelBuilder.Property(e => e.Model).HasMaxLength(50);

        modelBuilder.Property(e => e.SerialNumber).HasMaxLength(20);

        modelBuilder.Property(e => e.InventoryNumber).HasMaxLength(20);

        modelBuilder
            .HasOne(e => e.EquipmentType)
            .WithMany(t => t.Equipments);

        modelBuilder
            .HasOne(e => e.Department)
            .WithMany(d => d.Equipments);

        modelBuilder
            .HasOne(e => e.Department)
            .WithMany(d => d.Equipments);

        modelBuilder
            .HasOne(e => e.EquipmentState)
            .WithMany(s => s.Equipments);

        modelBuilder
            .HasOne(e => e.ResponsiblePerson)
            .WithMany(p => p.Equipments)
            .HasForeignKey(e => e.ResponsiblePersonId);

        modelBuilder
            .HasOne(e => e.User)
            .WithMany()
            .HasForeignKey( e => e.UserId);

        modelBuilder
            .HasOne(e => e.ServiceEngineer)
            .WithMany(t => t.Equipment);

        modelBuilder
            .HasOne(e => e.ObtainingType)
            .WithMany(t => t.Equipment);
    }
}