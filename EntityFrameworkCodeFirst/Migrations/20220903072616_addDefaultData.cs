using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCodeFirst.Migrations
{
    public partial class addDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DepartmentEmployee",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9820), "HR", null });

            migrationBuilder.InsertData(
                table: "DepartmentEmployee",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9821), "IT", null });

            migrationBuilder.InsertData(
                table: "DepartmentEmployee",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9822), "Sales", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CreatedDate", "DepartmentId", "EmpCode", "FristName", "LastName", "UpdatedDate" },
                values: new object[] { 1, 18, new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9885), 2, "Long.Nguyen", "Long", "Nguyen", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CreatedDate", "DepartmentId", "EmpCode", "FristName", "LastName", "UpdatedDate" },
                values: new object[] { 2, 18, new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9887), 1, "Long.Hoang", "Long", "Hoang", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CreatedDate", "DepartmentId", "EmpCode", "FristName", "LastName", "UpdatedDate" },
                values: new object[] { 3, 19, new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9887), 2, "Long.Manh", "Long", "Manh", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
