using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalDeviceSupervisor.Migrations
{
    public partial class SeedLocationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sql = (@"
                SET IDENTITY_INSERT Locations ON
                Insert INTO Locations (Id, BuildingId, RoomId) Values (1, 1, 1)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (2, 1, 2)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (3, 1, 3)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (4, 1, 4)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (5, 1, 5)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (6, 1, 6)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (7, 1, 7)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (8, 1, 8)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (9, 1, 9)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (10, 1, 10)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (11, 1, 11)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (12, 1, 12)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (13, 1, 13)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (14, 1, 14)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (15, 1, 15)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (16, 1, 16)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (17, 1, 17)
                Insert INTO Locations (Id, BuildingId, RoomId) Values (18, 1, 18)
                SET IDENTITY_INSERT Locations OFF
            ");

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string sql = (@"
                Delete Locations Where Id = 1
                Delete Locations Where Id = 2
                Delete Locations Where Id = 3
                Delete Locations Where Id = 4
                Delete Locations Where Id = 5
                Delete Locations Where Id = 6
                Delete Locations Where Id = 7
                Delete Locations Where Id = 8
                Delete Locations Where Id = 9
                Delete Locations Where Id = 10
                Delete Locations Where Id = 11
                Delete Locations Where Id = 12
                Delete Locations Where Id = 13
                Delete Locations Where Id = 14
                Delete Locations Where Id = 15
                Delete Locations Where Id = 16
                Delete Locations Where Id = 17
                Delete Locations Where Id = 18
            ");

            migrationBuilder.Sql(sql);
        }
    }
}
