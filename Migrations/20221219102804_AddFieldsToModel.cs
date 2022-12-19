using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiVeiculos.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsToModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataRevisao",
                table: "Motos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Quilometros",
                table: "Motos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataRevisao",
                table: "Carros",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Quilometros",
                table: "Carros",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataRevisao",
                table: "Motos");

            migrationBuilder.DropColumn(
                name: "Quilometros",
                table: "Motos");

            migrationBuilder.DropColumn(
                name: "DataRevisao",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "Quilometros",
                table: "Carros");
        }
    }
}
