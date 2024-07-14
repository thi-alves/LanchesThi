using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesThi.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Normal', 'Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Natural', 'Lanche feito com ingredientesintegrais e naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
