using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_efcoretest.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 1001, "Alice", 1234 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 1002, "Bob", 1255 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 1003, "Charlie", 1278 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
