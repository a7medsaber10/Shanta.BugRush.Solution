using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shanta.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddingShipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "ShipmentId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DeliveryGuyId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipments_AspNetUsers_DeliveryGuyId",
                        column: x => x.DeliveryGuyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08a46760-eebb-422b-8711-b551bc72f694", null, "supplier", "SUPPLIER" },
                    { "0b710696-0bd9-456e-9573-81f25d400f01", null, "admin", "ADMIN" },
                    { "1357017b-ba73-4349-bc12-7407840bedcc", null, "hr", "HR" },
                    { "1f9c291c-6b95-4452-95f3-584b415ed45c", null, "delivery", "DELIVERY" },
                    { "217a6aee-c5c9-4613-98c5-6bfb6e2d8f8d", null, "customer", "CUSTOMER" },
                    { "29d0fa2c-a97d-431a-ba70-66438dde91b7", null, "technicalsupport", "TECHNICALSUPPORT" },
                    { "38ee8e17-b761-4409-ad2e-07c89dab3831", null, "warehousemanager", "WAREHOUSEMANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipmentId",
                table: "Orders",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_DeliveryGuyId",
                table: "Shipments",
                column: "DeliveryGuyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shipments_ShipmentId",
                table: "Orders",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shipments_ShipmentId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ShipmentId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08a46760-eebb-422b-8711-b551bc72f694");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b710696-0bd9-456e-9573-81f25d400f01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1357017b-ba73-4349-bc12-7407840bedcc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f9c291c-6b95-4452-95f3-584b415ed45c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "217a6aee-c5c9-4613-98c5-6bfb6e2d8f8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29d0fa2c-a97d-431a-ba70-66438dde91b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38ee8e17-b761-4409-ad2e-07c89dab3831");

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "Orders");

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
        }
    }
}
