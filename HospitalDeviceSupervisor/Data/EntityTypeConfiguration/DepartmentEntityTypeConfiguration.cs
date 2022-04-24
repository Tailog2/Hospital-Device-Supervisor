using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDeviceSupervisor.Data.EntityTypeConfiguration
{
    public class DepartmentEntityTypeConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> modelBuilder)
        {

            modelBuilder.HasKey(d => d.Id);

            modelBuilder.Property(d => d.Name).HasMaxLength(50);

            modelBuilder
                .HasOne(d => d.UpperDepartment)
                .WithOne()
                .HasForeignKey<Department>(d => d.UpperDepartmentId);

            modelBuilder
                .HasOne(d => d.SubDepartment)
                .WithOne()
                .HasForeignKey<Department>(d => d.SubDepartmentId);

            modelBuilder
                .HasOne(d => d.DepartmentHead)
                .WithOne(p => p.Department)
                .HasForeignKey<Department>(d => d.DepartmentHeadId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .HasMany(d => d.DepartmentLocations)
                .WithMany(l => l.Department);

            modelBuilder
                .HasMany(d => d.Workers)
                .WithOne()
                .HasForeignKey(p => p.DepartmentId);
        }
    }
}
