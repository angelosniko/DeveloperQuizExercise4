using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class AddBeerRatingEntity2Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BeerRatingValue",
                table: "BeerRatings",
                type: "int",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BeerRatingValue",
                table: "BeerRatings",
                type: "int",
                maxLength: 1,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldNullable: true);
        }
    }
}
