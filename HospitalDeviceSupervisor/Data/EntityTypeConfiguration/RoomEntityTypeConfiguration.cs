using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration;

public class RoomEntityTypeConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> modelBuilder)
    {
        modelBuilder.HasKey(d => d.Id);

        modelBuilder.Property(r => r.Name).HasMaxLength(50);
    }
}