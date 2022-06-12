using Microsoft.EntityFrameworkCore.Migrations;

namespace SEEDCAFE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiHat = table.Column<string>(nullable: true),
                    AnhHienThi = table.Column<string>(nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    GioiThieu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
