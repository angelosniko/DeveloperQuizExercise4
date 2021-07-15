using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class AddBeerRatingEntityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("4ca8c3bb-7918-42b0-8051-ca693d28f854"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("741a0d2a-b7e1-4e42-b4d3-0af19e0c3022"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("af4009ac-aa42-43cb-8440-6a25b5178ad8"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("b8b72ec8-a901-477b-84d1-701b04676323"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("df96adac-3252-4ca9-a8d7-47a3e1fc8609"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("ec47f4f8-207b-45e1-a161-e4f1ef62d5df"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("f3f7ce9f-4bcd-4c06-a0e8-455273cb8a6f"));

            migrationBuilder.DropColumn(
                name: "BeerRating",
                table: "Beers");

            migrationBuilder.CreateTable(
                name: "BeerRatings",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BeerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BeerRatingValue = table.Column<int>(type: "int", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeerRatings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BeerRatings_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "Id", "BeerName", "BeerType" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Berry", "Griffin Beak Eldritch" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Nancy", "Swashbuckler Rye" },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "Eli", "Ivory Bones Sweet" },
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), "Arnold", "The Unseen Stafford" },
                    { new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"), "Seabury", "Toxic Reyson" },
                    { new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"), "Rutherford", "Fearless Cloven" },
                    { new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"), "Atherton", "Crow Ridley" }
                });

            migrationBuilder.InsertData(
                table: "BeerRatings",
                columns: new[] { "ID", "BeerId", "BeerRatingValue" },
                values: new object[,]
                {
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), 1 },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), 2 },
                    { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), 2 },
                    { new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"), new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BeerRatings_BeerId",
                table: "BeerRatings",
                column: "BeerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeerRatings");

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"));

            migrationBuilder.AddColumn<int>(
                name: "BeerRating",
                table: "Beers",
                type: "int",
                maxLength: 1,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "Id", "BeerName", "BeerRating", "BeerType" },
                values: new object[,]
                {
                    { new Guid("4ca8c3bb-7918-42b0-8051-ca693d28f854"), "Berry", 1, "Griffin Beak Eldritch" },
                    { new Guid("df96adac-3252-4ca9-a8d7-47a3e1fc8609"), "Nancy", 2, "Swashbuckler Rye" },
                    { new Guid("b8b72ec8-a901-477b-84d1-701b04676323"), "Eli", 3, "Ivory Bones Sweet" },
                    { new Guid("f3f7ce9f-4bcd-4c06-a0e8-455273cb8a6f"), "Arnold", 4, "The Unseen Stafford" },
                    { new Guid("741a0d2a-b7e1-4e42-b4d3-0af19e0c3022"), "Seabury", 5, "Toxic Reyson" },
                    { new Guid("af4009ac-aa42-43cb-8440-6a25b5178ad8"), "Rutherford", 4, "Fearless Cloven" },
                    { new Guid("ec47f4f8-207b-45e1-a161-e4f1ef62d5df"), "Atherton", 2, "Crow Ridley" }
                });
        }
    }
}
