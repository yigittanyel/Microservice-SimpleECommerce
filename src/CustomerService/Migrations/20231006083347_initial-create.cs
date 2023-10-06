using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CustomerService.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreatedAt", "Name", "Phone", "Status" },
                values: new object[,]
                {
                    { 1, "Address 1", new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9878), "Customer 1", "05555555555", true },
                    { 2, "Address 2", new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9906), "Customer 2", "05555555555", true },
                    { 3, "Address 3", new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9908), "Customer 3", "05555555555", true },
                    { 4, "Address 4", new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9909), "Customer 4", "05555555555", true },
                    { 5, "Address 5", new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9911), "Customer 5", "05555555555", true },
                    { 6, "Address 6", new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9913), "Customer 6", "05555555555", true },
                    { 7, "Address 7", new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9915), "Customer 7", "05555555555", true },
                    { 8, "Address 8", new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9916), "Customer 8", "05555555555", true },
                    { 9, "Address 9", new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9917), "Customer 9", "05555555555", true },
                    { 10, "Address 10", new DateTime(2023, 10, 6, 8, 33, 47, 227, DateTimeKind.Utc).AddTicks(9919), "Customer 10", "05555555555", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
