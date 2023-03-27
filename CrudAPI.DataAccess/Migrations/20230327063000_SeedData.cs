using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[] { 4, "Research" });

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2023, 3, 27, 11, 59, 59, 977, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2023, 3, 27, 11, 59, 59, 977, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Age", "DOB", "DepartmentId", "Email", "FirstName", "LastName", "Salary" },
                values: new object[] { 3, 10, new DateTime(2023, 3, 27, 11, 59, 59, 977, DateTimeKind.Local).AddTicks(4124), 2, "Amasha@gmail.com", "Steve DB", "Perera", 100L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2023, 3, 27, 11, 43, 38, 142, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2023, 3, 27, 11, 43, 38, 142, DateTimeKind.Local).AddTicks(7855));
        }
    }
}
