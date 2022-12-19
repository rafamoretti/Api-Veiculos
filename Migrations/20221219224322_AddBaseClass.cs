using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiVeiculos.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros",
                table: "Carros");

            migrationBuilder.RenameColumn(
                name: "MotoId",
                table: "Motos",
                newName: "VeiculoId");

            migrationBuilder.RenameColumn(
                name: "CarroId",
                table: "Carros",
                newName: "QuantidadeLugares");

            migrationBuilder.AddColumn<string>(
                name: "MaterialQuadro",
                table: "Motos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuantidadeLugares",
                table: "Carros",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoId",
                table: "Carros",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros",
                table: "Carros",
                column: "VeiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "MaterialQuadro",
                table: "Motos");

            migrationBuilder.DropColumn(
                name: "VeiculoId",
                table: "Carros");

            migrationBuilder.RenameColumn(
                name: "VeiculoId",
                table: "Motos",
                newName: "MotoId");

            migrationBuilder.RenameColumn(
                name: "QuantidadeLugares",
                table: "Carros",
                newName: "CarroId");

            migrationBuilder.AlterColumn<int>(
                name: "CarroId",
                table: "Carros",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros",
                table: "Carros",
                column: "CarroId");
        }
    }
}
