using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BeerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeerRating = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    BeerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beers_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "Id", "BeerId", "BeerName", "BeerRating", "BeerType" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), null, "Berry", 1, "Griffin Beak Eldritch" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), null, "Nancy", 2, "Swashbuckler Rye" },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), null, "Eli", 3, "Ivory Bones Sweet" },
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), null, "Arnold", 4, "The Unseen Stafford" },
                    { new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"), null, "Seabury", 5, "Toxic Reyson" },
                    { new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"), null, "Rutherford", 4, "Fearless Cloven" },
                    { new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"), null, "Atherton", 2, "Crow Ridley" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beers_BeerId",
                table: "Beers",
                column: "BeerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beers");
        }
    }
}
