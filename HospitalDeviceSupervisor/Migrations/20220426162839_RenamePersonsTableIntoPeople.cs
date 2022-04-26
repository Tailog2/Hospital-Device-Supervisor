using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalDeviceSupervisor.Migrations
{
    public partial class RenamePersonsTableIntoPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Persons_DepartmentHeadId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Persons_ResponsiblePersonId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Persons_UserId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Building_BuildingId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Departments_DepartmentId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Positions_PositionId",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building",
                table: "Building");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "People");

            migrationBuilder.RenameTable(
                name: "Building",
                newName: "Buildings");

            migrationBuilder.RenameColumn(
                name: "LustName",
                table: "People",
                newName: "LastName");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_PositionId",
                table: "People",
                newName: "IX_People_PositionId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_DepartmentId",
                table: "People",
                newName: "IX_People_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buildings",
                table: "Buildings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_People_DepartmentHeadId",
                table: "Departments",
                column: "DepartmentHeadId",
                principalTable: "People",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_People_ResponsiblePersonId",
                table: "Equipment",
                column: "ResponsiblePersonId",
                principalTable: "People",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_People_UserId",
                table: "Equipment",
                column: "UserId",
                principalTable: "People",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Buildings_BuildingId",
                table: "Locations",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Departments_DepartmentId",
                table: "People",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Positions_PositionId",
                table: "People",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_People_DepartmentHeadId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_People_ResponsiblePersonId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_People_UserId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Buildings_BuildingId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Departments_DepartmentId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Positions_PositionId",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buildings",
                table: "Buildings");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Persons");

            migrationBuilder.RenameTable(
                name: "Buildings",
                newName: "Building");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Persons",
                newName: "LustName");

            migrationBuilder.RenameIndex(
                name: "IX_People_PositionId",
                table: "Persons",
                newName: "IX_Persons_PositionId");

            migrationBuilder.RenameIndex(
                name: "IX_People_DepartmentId",
                table: "Persons",
                newName: "IX_Persons_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building",
                table: "Building",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Persons_DepartmentHeadId",
                table: "Departments",
                column: "DepartmentHeadId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Persons_ResponsiblePersonId",
                table: "Equipment",
                column: "ResponsiblePersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Persons_UserId",
                table: "Equipment",
                column: "UserId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Building_BuildingId",
                table: "Locations",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Departments_DepartmentId",
                table: "Persons",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Positions_PositionId",
                table: "Persons",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id");
        }
    }
}
