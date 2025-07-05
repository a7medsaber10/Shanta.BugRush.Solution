using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shanta.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Warehousing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "OutOfStock",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TotalStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "warehouses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_warehouses_AspNetUsers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "stocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductVariantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitMeasure = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stocks_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_stocks_warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "supplyOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplyOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_supplyOrders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_supplyOrders_warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "stockMovements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MovementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Movement = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stockMovements_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_stockMovements_stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_stockMovements_warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "supplyOrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplyOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductVariantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplyOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_supplyOrderItems_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_supplyOrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_supplyOrderItems_supplyOrders_SupplyOrderId",
                        column: x => x.SupplyOrderId,
                        principalTable: "supplyOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3094657e-0c14-4c45-a04b-a423810e1a77", null, "supplier", "SUPPLIER" },
                    { "774a2d56-f66e-416e-b150-58dfb0232661", null, "warehousemanager", "WAREHOUSEMANAGER" },
                    { "7d7b7c7e-c328-4e78-ac00-fbb06aa70659", null, "customer", "CUSTOMER" },
                    { "89c558a1-df8f-4140-a81f-133546cf4041", null, "hr", "HR" },
                    { "c42f89e1-2c4f-4055-b047-0dc19103e506", null, "delivery", "DELIVERY" },
                    { "c4dd3f0c-58c5-46b3-b86c-a4a9131bd557", null, "admin", "ADMIN" },
                    { "e9a4b2dd-d525-4cd3-b330-342c2e1b87c8", null, "technicalsupport", "TECHNICALSUPPORT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_stockMovements_StockId",
                table: "stockMovements",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_stockMovements_UserId",
                table: "stockMovements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_stockMovements_WarehouseId",
                table: "stockMovements",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_stocks_ProductId",
                table: "stocks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_stocks_ProductVariantId",
                table: "stocks",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_stocks_WarehouseId",
                table: "stocks",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrderItems_ProductId",
                table: "supplyOrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrderItems_ProductVariantId",
                table: "supplyOrderItems",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrderItems_SupplyOrderId",
                table: "supplyOrderItems",
                column: "SupplyOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrders_UserId",
                table: "supplyOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrders_WarehouseId",
                table: "supplyOrders",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_warehouses_ManagerId",
                table: "warehouses",
                column: "ManagerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stockMovements");

            migrationBuilder.DropTable(
                name: "supplyOrderItems");

            migrationBuilder.DropTable(
                name: "stocks");

            migrationBuilder.DropTable(
                name: "supplyOrders");

            migrationBuilder.DropTable(
                name: "warehouses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3094657e-0c14-4c45-a04b-a423810e1a77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "774a2d56-f66e-416e-b150-58dfb0232661");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d7b7c7e-c328-4e78-ac00-fbb06aa70659");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89c558a1-df8f-4140-a81f-133546cf4041");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42f89e1-2c4f-4055-b047-0dc19103e506");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4dd3f0c-58c5-46b3-b86c-a4a9131bd557");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9a4b2dd-d525-4cd3-b330-342c2e1b87c8");

            migrationBuilder.DropColumn(
                name: "OutOfStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TotalStock",
                table: "Products");

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
        }
    }
}
