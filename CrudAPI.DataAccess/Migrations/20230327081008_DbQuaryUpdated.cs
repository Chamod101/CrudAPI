using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DbQuaryUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "employees",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "employees",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "employees",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "departments",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2023, 3, 27, 13, 40, 7, 890, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2023, 3, 27, 13, 40, 7, 890, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DOB",
                value: new DateTime(2023, 3, 27, 13, 40, 7, 890, DateTimeKind.Local).AddTicks(781));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

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

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DOB",
                value: new DateTime(2023, 3, 27, 11, 59, 59, 977, DateTimeKind.Local).AddTicks(4124));
        }
    }
}
