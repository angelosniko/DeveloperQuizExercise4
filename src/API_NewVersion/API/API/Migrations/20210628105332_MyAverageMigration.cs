using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class MyAverageMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GetAverage",
                table: "Beers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GetAverage",
                table: "Beers");
        }
    }
}
