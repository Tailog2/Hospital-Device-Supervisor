using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration;

public class BuildingEntityTypeConfiguration : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> modelBuilder)
    {
        modelBuilder.HasKey(b => b.Id);

        modelBuilder.Property(b => b.BuildingName).HasMaxLength(50);
    }
}