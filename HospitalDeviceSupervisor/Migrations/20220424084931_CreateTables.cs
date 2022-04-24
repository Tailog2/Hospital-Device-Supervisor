using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalDeviceSupervisor.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentStates",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentTypes",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObtainingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<byte>(type: "tinyint", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObtainingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ThirdPartyPersons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LustName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PatronymicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ServiceCompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPartyPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThirdPartyPersons_ServiceCompanies_ServiceCompanyId",
                        column: x => x.ServiceCompanyId,
                        principalTable: "ServiceCompanies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LocationRoom",
                columns: table => new
                {
                    LocationsId = table.Column<int>(type: "int", nullable: false),
                    RoomsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationRoom", x => new { x.LocationsId, x.RoomsId });
                    table.ForeignKey(
                        name: "FK_LocationRoom_Locations_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationRoom_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentLocation",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DepartmentLocationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentLocation", x => new { x.DepartmentId, x.DepartmentLocationsId });
                    table.ForeignKey(
                        name: "FK_DepartmentLocation_Locations_DepartmentLocationsId",
                        column: x => x.DepartmentLocationsId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartmentHeadId = table.Column<int>(type: "int", nullable: false),
                    SubDepartmentId = table.Column<int>(type: "int", nullable: true),
                    UpperDepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Departments_SubDepartmentId",
                        column: x => x.SubDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Departments_Departments_UpperDepartmentId",
                        column: x => x.UpperDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LustName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PatronymicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<short>(type: "smallint", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maker = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EquipmentTypeId = table.Column<short>(type: "smallint", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    ResponsiblePersonId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    InventoryNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EquipmentStateId = table.Column<byte>(type: "tinyint", nullable: false),
                    IsRequiredRepair = table.Column<bool>(type: "bit", nullable: false),
                    IsCurrentlyInUse = table.Column<bool>(type: "bit", nullable: false),
                    ServiceCompanyId = table.Column<int>(type: "int", nullable: true),
                    ServiceEngineerId = table.Column<int>(type: "int", nullable: true),
                    ObtainingTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_EquipmentStates_EquipmentStateId",
                        column: x => x.EquipmentStateId,
                        principalTable: "EquipmentStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_EquipmentTypes_EquipmentTypeId",
                        column: x => x.EquipmentTypeId,
                        principalTable: "EquipmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipment_ObtainingTypes_ObtainingTypeId",
                        column: x => x.ObtainingTypeId,
                        principalTable: "ObtainingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Persons_ResponsiblePersonId",
                        column: x => x.ResponsiblePersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipment_Persons_UserId",
                        column: x => x.UserId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipment_ServiceCompanies_ServiceCompanyId",
                        column: x => x.ServiceCompanyId,
                        principalTable: "ServiceCompanies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipment_ThirdPartyPersons_ServiceEngineerId",
                        column: x => x.ServiceEngineerId,
                        principalTable: "ThirdPartyPersons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentLocation_DepartmentLocationsId",
                table: "DepartmentLocation",
                column: "DepartmentLocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentHeadId",
                table: "Departments",
                column: "DepartmentHeadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_SubDepartmentId",
                table: "Departments",
                column: "SubDepartmentId",
                unique: true,
                filter: "[SubDepartmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UpperDepartmentId",
                table: "Departments",
                column: "UpperDepartmentId",
                unique: true,
                filter: "[UpperDepartmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_DepartmentId",
                table: "Equipment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_EquipmentStateId",
                table: "Equipment",
                column: "EquipmentStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_EquipmentTypeId",
                table: "Equipment",
                column: "EquipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_LocationId",
                table: "Equipment",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ObtainingTypeId",
                table: "Equipment",
                column: "ObtainingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ResponsiblePersonId",
                table: "Equipment",
                column: "ResponsiblePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ServiceCompanyId",
                table: "Equipment",
                column: "ServiceCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ServiceEngineerId",
                table: "Equipment",
                column: "ServiceEngineerId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_UserId",
                table: "Equipment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationRoom_RoomsId",
                table: "LocationRoom",
                column: "RoomsId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_BuildingId",
                table: "Locations",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DepartmentId",
                table: "Persons",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PositionId",
                table: "Persons",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPartyPersons_ServiceCompanyId",
                table: "ThirdPartyPersons",
                column: "ServiceCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentLocation_Departments_DepartmentId",
                table: "DepartmentLocation",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Persons_DepartmentHeadId",
                table: "Departments",
                column: "DepartmentHeadId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Departments_DepartmentId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "DepartmentLocation");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "LocationRoom");

            migrationBuilder.DropTable(
                name: "EquipmentStates");

            migrationBuilder.DropTable(
                name: "EquipmentTypes");

            migrationBuilder.DropTable(
                name: "ObtainingTypes");

            migrationBuilder.DropTable(
                name: "ThirdPartyPersons");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "ServiceCompanies");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
