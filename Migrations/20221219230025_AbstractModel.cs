using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiVeiculos.Migrations
{
    /// <inheritdoc />
    public partial class AbstractModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LitrosCombustivel",
                table: "Motos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LitrosCombustivel",
                table: "Carros",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LitrosCombustivel",
                table: "Motos");

            migrationBuilder.DropColumn(
                name: "LitrosCombustivel",
                table: "Carros");
        }
    }
}
