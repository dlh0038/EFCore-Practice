using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_efcoretest.Migrations
{
    public partial class AddedPayrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "HourlyPay",
                table: "User",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HourlyPay",
                table: "User");
        }
    }
}
