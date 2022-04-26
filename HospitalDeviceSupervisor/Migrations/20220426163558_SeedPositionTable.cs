using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalDeviceSupervisor.Migrations
{
    public partial class SeedPositionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sql = (@"
                SET IDENTITY_INSERT Positions ON
                Insert INTO Positions (Id, Name) Values (1, 'Глава Отделения')
                Insert INTO Positions (Id, Name) Values (2, 'Доктор')
                Insert INTO Positions (Id, Name) Values (3, 'Медсестра')
                Insert INTO Positions (Id, Name) Values (4, 'Административный служащий')
                Insert INTO Positions (Id, Name) Values (5, 'Лаборант')
                Insert INTO Positions (Id, Name) Values (6, 'Санитар')
                SET IDENTITY_INSERT Positions OFF
            ");

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string sql = (@"
                Delete Positions Where Id = 1
                Delete Positions Where Id = 2
                Delete Positions Where Id = 3
                Delete Positions Where Id = 4
                Delete Positions Where Id = 5
                Delete Positions Where Id = 6
            ");

            migrationBuilder.Sql(sql);
        }
    }
}
