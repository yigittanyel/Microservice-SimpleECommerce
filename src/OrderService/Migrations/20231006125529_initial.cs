using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderService.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "OrderDate", "ProductId", "Quantity", "Status", "TotalPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5219), 1, new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5214), 1, 0, true, 100m },
                    { 2, new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5252), 1, new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5250), 2, 0, true, 200m },
                    { 3, new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5254), 2, new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5253), 3, 0, true, 300m },
                    { 4, new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5256), 3, new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5255), 4, 0, true, 400m },
                    { 5, new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5257), 4, new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5256), 1, 0, true, 500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
