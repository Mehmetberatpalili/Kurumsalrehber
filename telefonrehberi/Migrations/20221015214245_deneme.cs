using Microsoft.EntityFrameworkCore.Migrations;

namespace telefonrehberi.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departmanlars",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmanad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmanlars", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    perid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sehir = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.perid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "departmanlars");

            migrationBuilder.DropTable(
                name: "personels");
        }
    }
}
