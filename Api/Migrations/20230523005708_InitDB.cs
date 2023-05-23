using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Receipts",
                columns: new[] { "Id", "Item", "Quantity", "ReceiptDate" },
                values: new object[,]
                {
                    { 1, "Pen", 10, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Pen", 10, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Pen", 10, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Book", 10, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Book", 10, new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Book", 10, new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Book", 10, new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Bottle", 10, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Bottle", 10, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Bottle", 10, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Bottle", 10, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Cup", 10, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Cup", 10, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Cup", 10, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Pen", 10, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Pen", 10, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Pen", 10, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Book", 10, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Book", 10, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Book", 10, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Book", 10, new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Bottle", 10, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Bottle", 10, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Name", "Point", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pen1", 10, "3rd" },
                    { 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pen2", 10, "3rd" },
                    { 3, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pen3", 10, "Male" },
                    { 4, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book4", 10, "Female" },
                    { 5, new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book5", 10, "Female" },
                    { 6, new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book6", 10, "Female" },
                    { 7, new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book7", 10, "Female" },
                    { 8, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bottle1", 10, "3rd" },
                    { 9, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bottle2", 10, "Male" },
                    { 10, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bottle3", 10, "3rd" },
                    { 11, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bottle4", 10, "Male" },
                    { 12, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cup1", 10, "3rd" },
                    { 13, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cup2", 10, "Female" },
                    { 14, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cup3", 10, "Male" },
                    { 15, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pen11", 10, "3rd" },
                    { 16, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pen12", 10, "Male" },
                    { 17, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pen13", 10, "3rd" },
                    { 18, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book11", 10, "3rd" },
                    { 19, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book12", 10, "Male" },
                    { 20, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book13", 10, "3rd" },
                    { 21, new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book14", 10, "Male" },
                    { 22, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bottle11", 10, "Female" },
                    { 23, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bottle12", 10, "Female" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
