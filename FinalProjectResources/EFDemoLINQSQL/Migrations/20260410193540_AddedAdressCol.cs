using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDemoLINQSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdressCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "CustomerName" },
                values: new object[] { "Any Street", "Susan Smith" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "CustomerName" },
                values: new object[] { "Any Street", "Mike Jackson" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Address", "CustomerName" },
                values: new object[] { "Any Street", "Larry Jones" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                column: "CustomerName",
                value: "Doug Gegelman");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                column: "CustomerName",
                value: "Liam Hutton");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                column: "CustomerName",
                value: "Timothy Chesnut");
        }
    }
}
