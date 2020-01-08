using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMvc3_Bootstrap.Migrations
{
    public partial class initSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Mobile", "Name", "Title" },
                values: new object[] { 1, "總經理室", "david@gmail.com", "0933-152667", "David", "CEO" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Mobile", "Name", "Title" },
                values: new object[] { 2, "人事部", "mary@gmail.com", "0938-456889", "Mary", "管理師" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Mobile", "Name", "Title" },
                values: new object[] { 3, "財務部", "joe@gmail.com", "0925-331225", "Joe", "經理" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Mobile", "Name", "Title" },
                values: new object[] { 4, "業務部", "mark@gmail.com", "0935-863991", "Mark", "業務員" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Mobile", "Name", "Title" },
                values: new object[] { 5, "資訊部", "rose@gmail.com", "0987-335668", "Rose", "工程師" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Mobile", "Name", "Title" },
                values: new object[] { 6, "資訊部", "may@gmail.com", "0955-259885", "May", "工程師" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Mobile", "Name", "Title" },
                values: new object[] { 7, "業務部", "john@gmail.com", "0921-123456", "John", "業務員" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
