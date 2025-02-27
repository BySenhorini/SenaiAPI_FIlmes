using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_filmes_senai.Migrations
{
    /// <inheritdoc />
    public partial class Db_Filmes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    IdGenero = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Filme",
                columns: table => new
                {
                    IdFilme = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    IdGenero = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GeneroIdGenero = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.IdFilme);
                    table.ForeignKey(
                        name: "FK_Filme_Genero_GeneroIdGenero",
                        column: x => x.GeneroIdGenero,
                        principalTable: "Genero",
                        principalColumn: "IdGenero");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filme_GeneroIdGenero",
                table: "Filme",
                column: "GeneroIdGenero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filme");

            migrationBuilder.DropTable(
                name: "Genero");
        }
    }
}
