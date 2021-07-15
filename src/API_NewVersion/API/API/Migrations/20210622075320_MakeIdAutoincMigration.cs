using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class MakeIdAutoincMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Beers_BeerId",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_BeerId",
                table: "Beers");

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"));

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
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"));

            migrationBuilder.DropColumn(
                name: "BeerId",
                table: "Beers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "BeerId",
                table: "Beers",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Beers_BeerId",
                table: "Beers",
                column: "BeerId",
                principalTable: "Beers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
