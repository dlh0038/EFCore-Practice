using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_efcoretest.Migrations
{
    public partial class AddedSSN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SSN",
                table: "User",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1001,
                column: "SSN",
                value: "123-45-6789");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1002,
                column: "SSN",
                value: "987-65-4321");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1003,
                column: "SSN",
                value: "456-78-9123");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SSN",
                table: "User");
        }
    }
}
