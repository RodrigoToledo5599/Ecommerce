using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangingTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Produto_ProdutoId",
                table: "Imagens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imagens",
                table: "Imagens");

            migrationBuilder.RenameTable(
                name: "Imagens",
                newName: "ImagensProdutos");

            migrationBuilder.RenameIndex(
                name: "IX_Imagens_ProdutoId",
                table: "ImagensProdutos",
                newName: "IX_ImagensProdutos_ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImagensProdutos",
                table: "ImagensProdutos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagensProdutos_Produto_ProdutoId",
                table: "ImagensProdutos",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagensProdutos_Produto_ProdutoId",
                table: "ImagensProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImagensProdutos",
                table: "ImagensProdutos");

            migrationBuilder.RenameTable(
                name: "ImagensProdutos",
                newName: "Imagens");

            migrationBuilder.RenameIndex(
                name: "IX_ImagensProdutos_ProdutoId",
                table: "Imagens",
                newName: "IX_Imagens_ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imagens",
                table: "Imagens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Produto_ProdutoId",
                table: "Imagens",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id");
        }
    }
}
