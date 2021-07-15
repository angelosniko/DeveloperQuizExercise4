using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class RemoveBeerIDMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("3e784ca5-9639-423d-8a22-7cb2c41f3142"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("600ad036-1305-4460-99db-9f54112f1178"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("66b59e1f-adf4-4044-b546-1c438e1fa951"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("af83e446-83b7-430a-bc47-df675bd702bd"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("cc65d2ae-e39c-4744-9157-7b530635a403"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("d22649ce-d557-4e06-a781-f5801683c7a2"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("d8c210b9-6562-4b7d-9543-351e3afb813b"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "Id", "BeerName", "BeerRating", "BeerType" },
                values: new object[,]
                {
                    { new Guid("d8c210b9-6562-4b7d-9543-351e3afb813b"), "Berry", 1, "Griffin Beak Eldritch" },
                    { new Guid("3e784ca5-9639-423d-8a22-7cb2c41f3142"), "Nancy", 2, "Swashbuckler Rye" },
                    { new Guid("cc65d2ae-e39c-4744-9157-7b530635a403"), "Eli", 3, "Ivory Bones Sweet" },
                    { new Guid("66b59e1f-adf4-4044-b546-1c438e1fa951"), "Arnold", 4, "The Unseen Stafford" },
                    { new Guid("600ad036-1305-4460-99db-9f54112f1178"), "Seabury", 5, "Toxic Reyson" },
                    { new Guid("d22649ce-d557-4e06-a781-f5801683c7a2"), "Rutherford", 4, "Fearless Cloven" },
                    { new Guid("af83e446-83b7-430a-bc47-df675bd702bd"), "Atherton", 2, "Crow Ridley" }
                });
        }
    }
}
