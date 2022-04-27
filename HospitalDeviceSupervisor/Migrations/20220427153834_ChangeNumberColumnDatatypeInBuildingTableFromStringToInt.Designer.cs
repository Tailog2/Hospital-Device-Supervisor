﻿// <auto-generated />
using System;
using HospitalDeviceSupervisor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalDeviceSupervisor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220427153834_ChangeNumberColumnDatatypeInBuildingTableFromStringToInt")]
    partial class ChangeNumberColumnDatatypeInBuildingTableFromStringToInt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepartmentLocation", b =>
                {
                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentLocationsId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId", "DepartmentLocationsId");

                    b.HasIndex("DepartmentLocationsId");

                    b.ToTable("DepartmentLocation");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentHeadId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SubDepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("UpperDepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentHeadId")
                        .IsUnique();

                    b.HasIndex("SubDepartmentId")
                        .IsUnique()
                        .HasFilter("[SubDepartmentId] IS NOT NULL");

                    b.HasIndex("UpperDepartmentId")
                        .IsUnique()
                        .HasFilter("[UpperDepartmentId] IS NOT NULL");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<byte>("EquipmentStateId")
                        .HasColumnType("tinyint");

                    b.Property<short>("EquipmentTypeId")
                        .HasColumnType("smallint");

                    b.Property<string>("InventoryNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsCurrentlyInUse")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRequiredRepair")
                        .HasColumnType("bit");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Maker")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ObtainingTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ResponsiblePersonId")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("ServiceCompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceEngineerId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EquipmentStateId");

                    b.HasIndex("EquipmentTypeId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ObtainingTypeId");

                    b.HasIndex("ResponsiblePersonId");

                    b.HasIndex("ServiceCompanyId");

                    b.HasIndex("ServiceEngineerId");

                    b.HasIndex("UserId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.EquipmentState", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("EquipmentStates");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.EquipmentType", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("EquipmentTypes");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.ObtainingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("ObtainingTypes");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PatronymicName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<short?>("PositionId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Position", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.ServiceCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ServiceCompanies");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.ThirdPartyPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LustName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PatronymicName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Position")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ServiceCompanyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceCompanyId");

                    b.ToTable("ThirdPartyPersons");
                });

            modelBuilder.Entity("LocationRoom", b =>
                {
                    b.Property<int>("LocationsId")
                        .HasColumnType("int");

                    b.Property<int>("RoomsId")
                        .HasColumnType("int");

                    b.HasKey("LocationsId", "RoomsId");

                    b.HasIndex("RoomsId");

                    b.ToTable("LocationRoom");
                });

            modelBuilder.Entity("DepartmentLocation", b =>
                {
                    b.HasOne("HospitalDeviceSupervisor.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalDeviceSupervisor.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("DepartmentLocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Department", b =>
                {
                    b.HasOne("HospitalDeviceSupervisor.Models.Person", "DepartmentHead")
                        .WithOne("Department")
                        .HasForeignKey("HospitalDeviceSupervisor.Models.Department", "DepartmentHeadId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HospitalDeviceSupervisor.Models.Department", "SubDepartment")
                        .WithOne()
                        .HasForeignKey("HospitalDeviceSupervisor.Models.Department", "SubDepartmentId");

                    b.HasOne("HospitalDeviceSupervisor.Models.Department", "UpperDepartment")
                        .WithOne()
                        .HasForeignKey("HospitalDeviceSupervisor.Models.Department", "UpperDepartmentId");

                    b.Navigation("DepartmentHead");

                    b.Navigation("SubDepartment");

                    b.Navigation("UpperDepartment");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Equipment", b =>
                {
                    b.HasOne("HospitalDeviceSupervisor.Models.Department", "Department")
                        .WithMany("Equipments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalDeviceSupervisor.Models.EquipmentState", "EquipmentState")
                        .WithMany("Equipments")
                        .HasForeignKey("EquipmentStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalDeviceSupervisor.Models.EquipmentType", "EquipmentType")
                        .WithMany("Equipments")
                        .HasForeignKey("EquipmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalDeviceSupervisor.Models.Location", "Location")
                        .WithMany("Equipments")
                        .HasForeignKey("LocationId");

                    b.HasOne("HospitalDeviceSupervisor.Models.ObtainingType", "ObtainingType")
                        .WithMany("Equipment")
                        .HasForeignKey("ObtainingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalDeviceSupervisor.Models.Person", "ResponsiblePerson")
                        .WithMany("Equipments")
                        .HasForeignKey("ResponsiblePersonId");

                    b.HasOne("HospitalDeviceSupervisor.Models.ServiceCompany", "ServiceCompany")
                        .WithMany("Equipment")
                        .HasForeignKey("ServiceCompanyId");

                    b.HasOne("HospitalDeviceSupervisor.Models.ThirdPartyPerson", "ServiceEngineer")
                        .WithMany("Equipment")
                        .HasForeignKey("ServiceEngineerId");

                    b.HasOne("HospitalDeviceSupervisor.Models.Person", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Department");

                    b.Navigation("EquipmentState");

                    b.Navigation("EquipmentType");

                    b.Navigation("Location");

                    b.Navigation("ObtainingType");

                    b.Navigation("ResponsiblePerson");

                    b.Navigation("ServiceCompany");

                    b.Navigation("ServiceEngineer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Location", b =>
                {
                    b.HasOne("HospitalDeviceSupervisor.Models.Building", "Building")
                        .WithMany("Locations")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Person", b =>
                {
                    b.HasOne("HospitalDeviceSupervisor.Models.Department", null)
                        .WithMany("Workers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalDeviceSupervisor.Models.Position", "Position")
                        .WithMany("Persons")
                        .HasForeignKey("PositionId");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.ThirdPartyPerson", b =>
                {
                    b.HasOne("HospitalDeviceSupervisor.Models.ServiceCompany", "ServiceCompany")
                        .WithMany("Workers")
                        .HasForeignKey("ServiceCompanyId");

                    b.Navigation("ServiceCompany");
                });

            modelBuilder.Entity("LocationRoom", b =>
                {
                    b.HasOne("HospitalDeviceSupervisor.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalDeviceSupervisor.Models.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Building", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Department", b =>
                {
                    b.Navigation("Equipments");

                    b.Navigation("Workers");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.EquipmentState", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.EquipmentType", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Location", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.ObtainingType", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Person", b =>
                {
                    b.Navigation("Department")
                        .IsRequired();

                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.Position", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.ServiceCompany", b =>
                {
                    b.Navigation("Equipment");

                    b.Navigation("Workers");
                });

            modelBuilder.Entity("HospitalDeviceSupervisor.Models.ThirdPartyPerson", b =>
                {
                    b.Navigation("Equipment");
                });
#pragma warning restore 612, 618
        }
    }
}