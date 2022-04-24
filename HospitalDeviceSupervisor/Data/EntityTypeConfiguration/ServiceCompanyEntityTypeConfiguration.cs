using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration;

public class ServiceCompanyEntityTypeConfiguration : IEntityTypeConfiguration<ServiceCompany>
{
    public void Configure(EntityTypeBuilder<ServiceCompany> modelBuilder)
    {
        modelBuilder.HasKey(s => s.Id);

        modelBuilder.Property(s => s.Name).HasMaxLength(50);

        modelBuilder
            .HasMany(s => s.Workers)
            .WithOne(t => t.ServiceCompany);
    }
}