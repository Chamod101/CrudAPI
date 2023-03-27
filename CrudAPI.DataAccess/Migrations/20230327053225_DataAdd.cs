using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Age", "DOB", "Email", "FirstName", "LastName", "Salary" },
                values: new object[] { 1, 10, new DateTime(2023, 3, 27, 11, 2, 25, 357, DateTimeKind.Local).AddTicks(6291), "Chamod@gmail.com", "Chamod DB", "Perera", 100L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
