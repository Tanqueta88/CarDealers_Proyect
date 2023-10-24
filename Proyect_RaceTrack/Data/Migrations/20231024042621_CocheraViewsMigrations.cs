using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyect_RaceTrack.Data.Migrations
{
    /// <inheritdoc />
    public partial class CocheraViewsMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CocheraNombre",
                table: "Cochera",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CocheraNumero",
                table: "Cochera",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CocheraNombre",
                table: "Cochera");

            migrationBuilder.DropColumn(
                name: "CocheraNumero",
                table: "Cochera");
        }
    }
}
