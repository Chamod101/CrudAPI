using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrudAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentEntityAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Marketing" },
                    { 3, "HR" }
                });

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DOB", "DepartmentId" },
                values: new object[] { new DateTime(2023, 3, 27, 11, 43, 38, 142, DateTimeKind.Local).AddTicks(7836), 1 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Age", "DOB", "DepartmentId", "Email", "FirstName", "LastName", "Salary" },
                values: new object[] { 2, 10, new DateTime(2023, 3, 27, 11, 43, 38, 142, DateTimeKind.Local).AddTicks(7855), 3, "Amasha@gmail.com", "Amasha DB", "Perera", 100L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "employees");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2023, 3, 27, 11, 2, 25, 357, DateTimeKind.Local).AddTicks(6291));
        }
    }
}
