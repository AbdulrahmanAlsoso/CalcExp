using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcExp.Migrations
{
    /// <inheritdoc />
    public partial class UsersconfigurationwithupdateAppDBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Name", "Password" },
                values: new object[] { "Abdulrahman_140141", "Abdulrahman_140141" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
