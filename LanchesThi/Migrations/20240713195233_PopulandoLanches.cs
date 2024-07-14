using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesThi.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO " +
                "Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'http://www.macoratti.net/Imagens/Lanches/cheesesalada1.jpg', 'http://www.macoratti.net/Imagens/Lanches/cheesesalada1.jpg', 0, 'Cheese Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO " +
                "Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1, 'Pão, presunto, mussarela e tomate', 'Delicioso pão francês quentinho bem servidos com tomate', 1, 'http://www.macoratti.net/Imagens/Lanches/mistoquente4.jpg', 'http://www.macoratti.net/Imagens/Lanches/mistoquente4.jpg', 0, 'Misto Quente', 8.50)");

            migrationBuilder.Sql("INSERT INTO " +
                "Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1, 'Pão, hambúrguer, presunto, mussarela e batata palha', 'Delicioso pão de hambúrger com presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'http://www.macoratti.net/Imagens/Lanches/cheeseburger1.jpg', 'http://www.macoratti.net/Imagens/Lanches/cheeseburger1.jpg', 0, 'Cheese Burger', 11.50)");

            migrationBuilder.Sql("INSERT INTO " +
                "Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(2, 'Pão integral, queijo branco, peito de peru, cenoura, alface, iogurte', 'Delicioso pão integral com...', 1, 'http://www.macoratti.net/Imagens/Lanches/lanchesnatural.jpg', 'http://www.macoratti.net/Imagens/Lanches/lanchesnatural.jpg', 1, 'Lanche Naural Peito de Peru', 14.50)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");

        }
    }
}
