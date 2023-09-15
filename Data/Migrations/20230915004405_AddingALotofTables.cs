using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingALotofTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contas",
                table: "Contas");

            migrationBuilder.DropColumn(
                name: "Imagem1",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Imagem2",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Imagem3",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Imagem4",
                table: "Produto");

            migrationBuilder.RenameTable(
                name: "Contas",
                newName: "Account");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Favoritos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Favoritos_Account_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favoritos_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagens_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemCarrinho",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ItemCarrinho_Account_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCarrinho_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "CategoriaId", "Descricao", "ImagemPrincipal", "Name", "Price" },
                values: new object[,]
                {
                    { 8, 1, null, null, "Head Set com fio RedDragon", 219f },
                    { 9, 3, null, null, "Monitor gamer Husky 27'' QHD 165hz ", 1300f },
                    { 10, 8, null, null, "Tv 8k Sansung", 4500f },
                    { 11, 5, null, null, "placa b450m am4 ddr4 Terabyte ", 580f },
                    { 12, 4, null, null, "Motorola Moto E13 64GB 4GB RAM Camera 13MB", 630f },
                    { 13, 7, null, null, "ryzen 5 3600X", 800f },
                    { 14, 10, null, null, "Teclado Gamer Hyper X Alloy Core RGB ABNT2", 200f },
                    { 15, 12, "PCIe GEN4x4\n Leitura: 7400 MB/s\nGravação: 6400 MB/s", null, "SSD 2TB XPG S70 Blade", 1040f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_ProdutoId",
                table: "Favoritos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_UsuarioId",
                table: "Favoritos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_ProdutoId",
                table: "Imagens",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCarrinho_ProdutoId",
                table: "ItemCarrinho",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCarrinho_UsuarioId",
                table: "ItemCarrinho",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favoritos");

            migrationBuilder.DropTable(
                name: "Imagens");

            migrationBuilder.DropTable(
                name: "ItemCarrinho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "Contas");

            migrationBuilder.AddColumn<string>(
                name: "Imagem1",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagem2",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagem3",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagem4",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contas",
                table: "Contas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4" },
                values: new object[] { null, null, null, null });
        }
    }
}
