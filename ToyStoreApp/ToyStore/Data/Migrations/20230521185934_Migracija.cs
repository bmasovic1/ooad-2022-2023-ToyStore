using Microsoft.EntityFrameworkCore.Migrations;

namespace ToyStore.Data.Migrations
{
    public partial class Migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtikliId",
                table: "Narudzba");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtikliId",
                table: "Narudzba",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
