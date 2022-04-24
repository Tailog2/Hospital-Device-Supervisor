using System.Reflection;
using HospitalDeviceSupervisor.Data.EntityTypeConfiguration;
using HospitalDeviceSupervisor.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalDeviceSupervisor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DepartmentEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LocationEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BuildingEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RoomEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EquipmentEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ObtainingTypeEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PositionEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ServiceCompanyEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ThirdPartyPersonEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EquipmentTypeEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EquipmentStateEntityTypeConfiguration).Assembly);
        }

        public DbSet<Equipment> Equipment { get; set; } = null!;
        public DbSet<Building> Building { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<EquipmentState> EquipmentStates { get; set; } = null!;
        public DbSet<EquipmentType> EquipmentTypes { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<ObtainingType> ObtainingTypes { get; set; } = null!;
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<ServiceCompany> ServiceCompanies { get; set; } = null!;
        public DbSet<ThirdPartyPerson> ThirdPartyPersons { get; set; } = null!;
    }
}
