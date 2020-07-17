using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedioAmbienteWeb.Data.Migrations
{
    public partial class SubirFotoPersna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FotografiaPerfil",
                table: "Personas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotografiaPerfil",
                table: "Personas");
        }
    }
}
