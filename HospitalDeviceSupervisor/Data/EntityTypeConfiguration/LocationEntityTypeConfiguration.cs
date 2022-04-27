using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration;

public class LocationEntityTypeConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> modelBuilder)
    {

        modelBuilder.HasKey(d => d.Id);

        modelBuilder
            .HasOne(l => l.Building)
            .WithMany(b => b.Locations);

        modelBuilder
            .HasOne(l => l.Building)
            .WithMany(b => b.Locations);
    }
}