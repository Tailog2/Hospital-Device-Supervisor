using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration;

public class ObtainingTypeEntityTypeConfiguration : IEntityTypeConfiguration<ObtainingType>
{
    public void Configure(EntityTypeBuilder<ObtainingType> modelBuilder)
    {
        modelBuilder.HasKey(o => o.Id);

        modelBuilder.Property(o => o.Name).HasMaxLength(50);
    }
}