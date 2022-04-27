using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalDeviceSupervisor.Migrations
{
    public partial class SeedBuildingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sql = (@"
                SET IDENTITY_INSERT Buildings ON
                Insert INTO Buildings (Id, Number, Name) Values (1, 11, null)
                Insert INTO Buildings (Id, Number, Name) Values (2, 44, null)
                Insert INTO Buildings (Id, Number, Name) Values (3, 54, 'Нефрологический корпус')
                Insert INTO Buildings (Id, Number, Name) Values (4, 4, 'Акушерское отделение')
                Insert INTO Buildings (Id, Number, Name) Values (5, 5, 'Поликлиника')
                Insert INTO Buildings (Id, Number, Name) Values (6, 33, 'Бактериологическая лаборатория')
                SET IDENTITY_INSERT Buildings OFF
            ");

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string sql = (@"
                Delete Buildings Where Id = 1
                Delete Buildings Where Id = 2
                Delete Buildings Where Id = 3
                Delete Buildings Where Id = 4
                Delete Buildings Where Id = 5
                Delete Buildings Where Id = 6
            ");

            migrationBuilder.Sql(sql);
        }
    }
}
