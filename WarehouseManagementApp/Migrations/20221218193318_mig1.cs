using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "warehouses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.ID);
                    table.ForeignKey(
                        name: "FK_stores_warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "warehouses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "warehouse_products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouse_products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_warehouse_products_products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_warehouse_products_warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "warehouses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreID = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    completed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_orders_stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "stores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "store_products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    StoreID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_store_products_products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_store_products_stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "stores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_order_products_orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_products_products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_order_products_OrderID",
                table: "order_products",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_order_products_ProductID",
                table: "order_products",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_orders_StoreID",
                table: "orders",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_store_products_ProductID",
                table: "store_products",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_store_products_StoreID",
                table: "store_products",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_stores_WarehouseID",
                table: "stores",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_warehouse_products_ProductID",
                table: "warehouse_products",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_warehouse_products_WarehouseID",
                table: "warehouse_products",
                column: "WarehouseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "order_products");

            migrationBuilder.DropTable(
                name: "store_products");

            migrationBuilder.DropTable(
                name: "warehouse_products");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "stores");

            migrationBuilder.DropTable(
                name: "warehouses");
        }
    }
}
