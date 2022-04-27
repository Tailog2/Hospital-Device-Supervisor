using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalDeviceSupervisor.Migrations
{
    public partial class RenameRoomColumnRoomsIdInLocationsTableToRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentLocation_Departments_DepartmentId",
                table: "DepartmentLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Rooms_RoomsId",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentLocation",
                table: "DepartmentLocation");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentLocation_DepartmentLocationsId",
                table: "DepartmentLocation");

            migrationBuilder.RenameColumn(
                name: "RoomsId",
                table: "Locations",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_RoomsId",
                table: "Locations",
                newName: "IX_Locations_RoomId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "DepartmentLocation",
                newName: "DepartmentsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentLocation",
                table: "DepartmentLocation",
                columns: new[] { "DepartmentLocationsId", "DepartmentsId" });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentLocation_DepartmentsId",
                table: "DepartmentLocation",
                column: "DepartmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentLocation_Departments_DepartmentsId",
                table: "DepartmentLocation",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Rooms_RoomId",
                table: "Locations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentLocation_Departments_DepartmentsId",
                table: "DepartmentLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Rooms_RoomId",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentLocation",
                table: "DepartmentLocation");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentLocation_DepartmentsId",
                table: "DepartmentLocation");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Locations",
                newName: "RoomsId");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_RoomId",
                table: "Locations",
                newName: "IX_Locations_RoomsId");

            migrationBuilder.RenameColumn(
                name: "DepartmentsId",
                table: "DepartmentLocation",
                newName: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentLocation",
                table: "DepartmentLocation",
                columns: new[] { "DepartmentId", "DepartmentLocationsId" });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentLocation_DepartmentLocationsId",
                table: "DepartmentLocation",
                column: "DepartmentLocationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentLocation_Departments_DepartmentId",
                table: "DepartmentLocation",
                column: "DepartmentId",
                principalTable: "Departments",
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
    }
}
