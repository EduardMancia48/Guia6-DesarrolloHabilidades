using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Guia6_Desarrollo.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    AutorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.AutorID);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    LibroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutorID = table.Column<int>(type: "int", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.LibroID);
                    table.ForeignKey(
                        name: "FK_Libros_Autores_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Autores",
                        principalColumn: "AutorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Libros_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorID", "Apellido", "Nombre" },
                values: new object[,]
                {
                    { 1, "García Márquez", "Gabriel" },
                    { 2, "Allende", "Isabel" },
                    { 3, "Rowling", "J.K." },
                    { 4, "Orwell", "George" },
                    { 5, "Austen", "Jane" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaID", "Nombre" },
                values: new object[,]
                {
                    { 1, "Ficción" },
                    { 2, "Ciencia Ficción" },
                    { 3, "Fantasía" },
                    { 4, "Histórico" },
                    { 5, "Romance" }
                });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "LibroID", "AutorID", "CategoriaID", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cien Años de Soledad" },
                    { 2, 2, 4, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La Casa de los Espíritus" },
                    { 3, 3, 3, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter y la Piedra Filosofal" },
                    { 4, 4, 2, new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "1984" },
                    { 5, 5, 5, new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orgullo y Prejuicio" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_AutorID",
                table: "Libros",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_CategoriaID",
                table: "Libros",
                column: "CategoriaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
