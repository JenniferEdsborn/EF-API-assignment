using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Firms",
                columns: new[] { "ID", "FirmName", "OrganizationNumber" },
                values: new object[,]
                {
                    { 1, "Swedish AB", 123456789 },
                    { 2, "Norweigan AB", 987654321 }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "ID", "PositionName" },
                values: new object[,]
                {
                    { 1, "Software Developer" },
                    { 2, "Manager" },
                    { 3, "Adminstrator" },
                    { 4, "HR Manager" },
                    { 5, "Budget Analyst" },
                    { 6, "Technical Support Engineer" },
                    { 7, "Paralegal" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "DepartmentName", "FirmID" },
                values: new object[,]
                {
                    { 1, "Administration", 1 },
                    { 2, "Marketing", 1 },
                    { 3, "HR", 1 },
                    { 4, "Customer Service", 1 },
                    { 5, "IT", 1 },
                    { 6, "Finance", 1 },
                    { 7, "Production", 1 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "DepartmentID", "FirstName", "LastName", "Salary", "UnionMember" },
                values: new object[,]
                {
                    { 1, 5, "Frodo", "Baggins", 35000, true },
                    { 2, 5, "Rhaynera", "Targaryen", 35000, true },
                    { 3, 5, "Rick", "Astley", 32700, false },
                    { 4, 2, "Optimus", "Prime", 44000, false },
                    { 5, 1, "Norman", "Bates", 40000, true },
                    { 6, 4, "Wednesday", "Addams", 38850, false },
                    { 7, 4, "Inigo", "Montoya", 46000, true },
                    { 8, 5, "Han", "Solo", 40000, true },
                    { 9, 3, "Ellen", "Ripley", 37500, true },
                    { 10, 7, "Tyler", "Durden", 34100, true },
                    { 11, 1, "Michael", "Corleone", 44000, false },
                    { 12, 1, "Riley", "Show", 45000, false }
                });

            migrationBuilder.InsertData(
                table: "EmployeePositions",
                columns: new[] { "EmployeeID", "PositionID" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 3 },
                    { 7, 6 },
                    { 8, 1 },
                    { 8, 2 },
                    { 9, 2 },
                    { 10, 7 },
                    { 11, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
