using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration;

public class PositionEntityTypeConfiguration : IEntityTypeConfiguration<Position>       
{
    public void Configure(EntityTypeBuilder<Position> modelBuilder)
    {
        modelBuilder.HasKey(p => p.Id);

        modelBuilder.Property(p => p.Name).HasMaxLength(50);
    }
}