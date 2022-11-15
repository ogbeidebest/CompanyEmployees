using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployee.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"), "583 Wall Dr. Gwyan Oak, MD 21207", "USA", "Microsoft" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "1600 Amphitheatre Parkway Mountain View, CA 94043", "USA", "Google" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"), 26, new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"), "John Doe", "Software Developer" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), 30, new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"), "Jane Doe", "Software Developer" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b36"), 35, new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"), "Emmanuel Imion", "Administration" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b36"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"));
        }
    }
}
