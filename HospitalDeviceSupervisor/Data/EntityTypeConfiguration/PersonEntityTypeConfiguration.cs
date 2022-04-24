using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration;

public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> modelBuilder)
    {
        modelBuilder.HasKey(p => p.Id);

        modelBuilder.Property(p => p.FirstName).HasMaxLength(50);

        modelBuilder.Property(p => p.LustName).HasMaxLength(50);

        modelBuilder.Property(p => p.PatronymicName).HasMaxLength(50);

        modelBuilder.Property(p => p.PhoneNumber).HasMaxLength(20);
    }
}