using Microsoft.EntityFrameworkCore.Migrations;

namespace telefonrehberi.Migrations
{
    public partial class deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sehir",
                table: "personels",
                newName: "Gorev");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "personels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BirimID",
                table: "personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CalistigiBirim",
                table: "personels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tc",
                table: "personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "telefon",
                table: "personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "birim",
                columns: table => new
                {
                    BirimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirimYoneticisi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_birim", x => x.BirimID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personels_BirimID",
                table: "personels",
                column: "BirimID");

            migrationBuilder.AddForeignKey(
                name: "FK_personels_birim_BirimID",
                table: "personels",
                column: "BirimID",
                principalTable: "birim",
                principalColumn: "BirimID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_birim_BirimID",
                table: "personels");

            migrationBuilder.DropTable(
                name: "birim");

            migrationBuilder.DropIndex(
                name: "IX_personels_BirimID",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "BirimID",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "CalistigiBirim",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "Tc",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "telefon",
                table: "personels");

            migrationBuilder.RenameColumn(
                name: "Gorev",
                table: "personels",
                newName: "sehir");
        }
    }
}
