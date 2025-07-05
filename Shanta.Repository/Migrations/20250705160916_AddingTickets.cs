using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shanta.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddingTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2789d79a-d2e1-4ce5-949f-2c67af85522e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29725440-9079-41c7-8628-9c85d35232e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d6b1234-78ab-4f6e-8a68-188552d8034c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8162b920-c6bc-4126-ad34-6f8f876d0568");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91573a37-666c-4656-b75c-f94583e6fe52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6366f8c-6f55-4571-b11d-a9a255acf0fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2ecce0-a1a2-4aaf-9328-42eb06c479ef");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "ProductVariants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "supportTickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supportTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_supportTickets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TicketResponses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResponseText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketResponses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TicketResponses_supportTickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "supportTickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28fac03d-eeda-42fc-b302-4eaf284c1f8f", null, "customer", "CUSTOMER" },
                    { "40dad09e-b18e-4332-8013-9cd11bd25ddc", null, "warehousemanager", "WAREHOUSEMANAGER" },
                    { "473ce8a9-2263-471d-ab03-d8da9b61af38", null, "supplier", "SUPPLIER" },
                    { "ba649d8e-b066-47bf-8a94-3fb88ca1b110", null, "delivery", "DELIVERY" },
                    { "c9b13baf-6d97-4d1c-a1ba-97ff932a045a", null, "admin", "ADMIN" },
                    { "e2555237-49da-456d-88d5-81076e4e7f6d", null, "technicalsupport", "TECHNICALSUPPORT" },
                    { "e8bcb865-dc0b-46da-8953-03f9ee9d0a00", null, "hr", "HR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_supportTickets_UserId",
                table: "supportTickets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketResponses_TicketId",
                table: "TicketResponses",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketResponses_UserId",
                table: "TicketResponses",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketResponses");

            migrationBuilder.DropTable(
                name: "supportTickets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28fac03d-eeda-42fc-b302-4eaf284c1f8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40dad09e-b18e-4332-8013-9cd11bd25ddc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "473ce8a9-2263-471d-ab03-d8da9b61af38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba649d8e-b066-47bf-8a94-3fb88ca1b110");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9b13baf-6d97-4d1c-a1ba-97ff932a045a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2555237-49da-456d-88d5-81076e4e7f6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8bcb865-dc0b-46da-8953-03f9ee9d0a00");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "ProductVariants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2789d79a-d2e1-4ce5-949f-2c67af85522e", null, "admin", "ADMIN" },
                    { "29725440-9079-41c7-8628-9c85d35232e4", null, "hr", "HR" },
                    { "5d6b1234-78ab-4f6e-8a68-188552d8034c", null, "technicalsupport", "TECHNICALSUPPORT" },
                    { "8162b920-c6bc-4126-ad34-6f8f876d0568", null, "customer", "CUSTOMER" },
                    { "91573a37-666c-4656-b75c-f94583e6fe52", null, "warehousemanager", "WAREHOUSEMANAGER" },
                    { "a6366f8c-6f55-4571-b11d-a9a255acf0fb", null, "delivery", "DELIVERY" },
                    { "cc2ecce0-a1a2-4aaf-9328-42eb06c479ef", null, "supplier", "SUPPLIER" }
                });
        }
    }
}
