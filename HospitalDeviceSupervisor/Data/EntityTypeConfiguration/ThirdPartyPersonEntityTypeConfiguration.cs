using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration;

public class ThirdPartyPersonEntityTypeConfiguration : IEntityTypeConfiguration<ThirdPartyPerson>
{
    public void Configure(EntityTypeBuilder<ThirdPartyPerson> modelBuilder)
    {
        modelBuilder.HasKey(t => t.Id);

        modelBuilder.Property(t => t.FirstName).HasMaxLength(50);

        modelBuilder.Property(t => t.LustName).HasMaxLength(50);

        modelBuilder.Property(t => t.PatronymicName).HasMaxLength(50);

        modelBuilder.Property(t => t.PhoneNumber).HasMaxLength(20);

        modelBuilder.Property(t => t.Position).HasMaxLength(50);
    }
}