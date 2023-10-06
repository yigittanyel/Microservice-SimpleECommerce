using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductService.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 6, 6, 29, 37, 104, DateTimeKind.Utc).AddTicks(7762), "Description 1", "Product 1", 10m, true, 10 },
                    { 2, new DateTime(2023, 10, 6, 6, 29, 37, 104, DateTimeKind.Utc).AddTicks(7792), "Description 2", "Product 2", 20m, true, 20 },
                    { 3, new DateTime(2023, 10, 6, 6, 29, 37, 104, DateTimeKind.Utc).AddTicks(7794), "Description 3", "Product 3", 30m, true, 30 },
                    { 4, new DateTime(2023, 10, 6, 6, 29, 37, 104, DateTimeKind.Utc).AddTicks(7795), "Description 4", "Product 4", 40m, true, 40 },
                    { 5, new DateTime(2023, 10, 6, 6, 29, 37, 104, DateTimeKind.Utc).AddTicks(7796), "Description 5", "Product 5", 50m, true, 50 },
                    { 6, new DateTime(2023, 10, 6, 6, 29, 37, 104, DateTimeKind.Utc).AddTicks(7800), "Description 6", "Product 6", 60m, true, 60 },
                    { 7, new DateTime(2023, 10, 6, 6, 29, 37, 104, DateTimeKind.Utc).AddTicks(7801), "Description 7", "Product 7", 70m, true, 70 },
                    { 8, new DateTime(2023, 10, 6, 6, 29, 37, 104, DateTimeKind.Utc).AddTicks(7802), "Description 8", "Product 8", 80m, true, 80 },
                    { 9, new DateTime(2023, 10, 6, 6, 29, 37, 104, DateTimeKind.Utc).AddTicks(7803), "Description 9", "Product 9", 90m, true, 90 },
                    { 10, new DateTime(2023, 10, 6, 6, 29, 37, 104, DateTimeKind.Utc).AddTicks(7805), "Description 10", "Product 10", 100m, true, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
