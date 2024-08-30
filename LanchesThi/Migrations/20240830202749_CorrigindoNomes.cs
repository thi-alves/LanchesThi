using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesThi.Migrations
{
    /// <inheritdoc />
    public partial class CorrigindoNomes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhe_Lanches_LancheId",
                table: "PedidoDetalhe");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhe_Pedido_PedidoId",
                table: "PedidoDetalhe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoDetalhe",
                table: "PedidoDetalhe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido");

            migrationBuilder.RenameTable(
                name: "PedidoDetalhe",
                newName: "PedidoDetalhes");

            migrationBuilder.RenameTable(
                name: "Pedido",
                newName: "Pedidos");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoDetalhe_PedidoId",
                table: "PedidoDetalhes",
                newName: "IX_PedidoDetalhes_PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoDetalhe_LancheId",
                table: "PedidoDetalhes",
                newName: "IX_PedidoDetalhes_LancheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoDetalhes",
                table: "PedidoDetalhes",
                column: "PedidoDetalheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "Pedidoid");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Lanches_LancheId",
                table: "PedidoDetalhes",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Pedidos_PedidoId",
                table: "PedidoDetalhes",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Pedidoid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Lanches_LancheId",
                table: "PedidoDetalhes");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Pedidos_PedidoId",
                table: "PedidoDetalhes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoDetalhes",
                table: "PedidoDetalhes");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "Pedido");

            migrationBuilder.RenameTable(
                name: "PedidoDetalhes",
                newName: "PedidoDetalhe");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoDetalhes_PedidoId",
                table: "PedidoDetalhe",
                newName: "IX_PedidoDetalhe_PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoDetalhes_LancheId",
                table: "PedidoDetalhe",
                newName: "IX_PedidoDetalhe_LancheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido",
                column: "Pedidoid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoDetalhe",
                table: "PedidoDetalhe",
                column: "PedidoDetalheId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhe_Lanches_LancheId",
                table: "PedidoDetalhe",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhe_Pedido_PedidoId",
                table: "PedidoDetalhe",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Pedidoid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
