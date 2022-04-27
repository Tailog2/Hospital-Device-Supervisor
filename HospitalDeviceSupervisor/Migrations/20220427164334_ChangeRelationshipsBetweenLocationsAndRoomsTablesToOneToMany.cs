using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalDeviceSupervisor.Migrations
{
    public partial class ChangeRelationshipsBetweenLocationsAndRoomsTablesToOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Buildings_BuildingId",
                table: "Locations");

            migrationBuilder.DropTable(
                name: "LocationRoom");

            migrationBuilder.AddColumn<int>(
                name: "RoomsId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_RoomsId",
                table: "Locations",
                column: "RoomsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Buildings_BuildingId",
                table: "Locations",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Rooms_RoomsId",
                table: "Locations",
                column: "RoomsId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Buildings_BuildingId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Rooms_RoomsId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_RoomsId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "RoomsId",
                table: "Locations");

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

            migrationBuilder.CreateIndex(
                name: "IX_LocationRoom_RoomsId",
                table: "LocationRoom",
                column: "RoomsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Buildings_BuildingId",
                table: "Locations",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id");
        }
    }
}
