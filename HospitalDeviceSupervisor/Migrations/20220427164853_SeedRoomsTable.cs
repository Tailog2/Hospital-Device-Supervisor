using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalDeviceSupervisor.Migrations
{
    public partial class SeedRoomsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sql = (@"
                SET IDENTITY_INSERT Rooms ON
                Insert INTO Rooms (Id, Name) Values (1, 12)
                Insert INTO Rooms(Id, Name) Values(2, '13')
                Insert INTO Rooms(Id, Name) Values(3, '14')
                Insert INTO Rooms(Id, Name) Values(4, '15')
                Insert INTO Rooms(Id, Name) Values(5, '16')
                Insert INTO Rooms(Id, Name) Values(6, '17')
                Insert INTO Rooms(Id, Name) Values(7, '18')
                Insert INTO Rooms(Id, Name) Values(8, '19')
                Insert INTO Rooms(Id, Name) Values(9, '20')
                Insert INTO Rooms(Id, Name) Values(10, '21')
                Insert INTO Rooms(Id, Name) Values(11, '22')
                Insert INTO Rooms(Id, Name) Values(12, '23')
                Insert INTO Rooms(Id, Name) Values(13, '24')
                Insert INTO Rooms(Id, Name) Values(14, '25')
                Insert INTO Rooms(Id, Name) Values(15, '26')
                Insert INTO Rooms(Id, Name) Values(16, '27')
                Insert INTO Rooms(Id, Name) Values(17, '30')
                Insert INTO Rooms(Id, Name) Values(18, 'Экспресс лаборатория')
                SET IDENTITY_INSERT Rooms OFF
            ");

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string sql = (@"
                Delete Rooms Where Id = 1
                Delete Rooms Where Id = 2
                Delete Rooms Where Id = 3
                Delete Rooms Where Id = 4
                Delete Rooms Where Id = 5
                Delete Rooms Where Id = 6
                Delete Rooms Where Id = 7
                Delete Rooms Where Id = 8
                Delete Rooms Where Id = 9
                Delete Rooms Where Id = 10
                Delete Rooms Where Id = 11
                Delete Rooms Where Id = 12
                Delete Rooms Where Id = 13
                Delete Rooms Where Id = 14
                Delete Rooms Where Id = 15
                Delete Rooms Where Id = 16
                Delete Rooms Where Id = 17
                Delete Rooms Where Id = 18
            ");

            migrationBuilder.Sql(sql);
        }
    }
}
