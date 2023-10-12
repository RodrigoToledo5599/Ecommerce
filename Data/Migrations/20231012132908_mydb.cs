using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class mydb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ImagemPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Category_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

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
                name: "ImagensProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagensProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagensProdutos_Produto_ProdutoId",
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
                table: "Account",
                columns: new[] { "Id", "Email", "Name", "Role", "Senha" },
                values: new object[,]
                {
                    { 1, "123@gmail.com", "123", 0, "123" },
                    { 13, "ADM@gmail.com", "ADM", 1, "adm123" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fone de ouvido" },
                    { 2, "Placa Programável" },
                    { 3, "Monitor" },
                    { 4, "Smartphone" },
                    { 5, "Placa mãe" },
                    { 6, "Gpu" },
                    { 7, "Cpu" },
                    { 8, "TV" },
                    { 9, "Fonte de Alimentação" },
                    { 10, "Teclado" },
                    { 11, "Mouse" },
                    { 12, "SSD" },
                    { 13, "HD" }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "CategoriaId", "Descricao", "ImagemPrincipal", "Name", "Price" },
                values: new object[,]
                {
                    { 3, null, null, null, "Pc Gamer", 9000f },
                    { 1, 8, null, null, "Tv", 3000f },
                    { 2, 4, null, null, "Celular", 760f },
                    { 4, 2, null, null, "Arduino Uno", 50f },
                    { 5, 2, null, null, "Esp-32", 70f },
                    { 6, 1, null, null, "Head Set Gamer Hyper X sem fio", 650f },
                    { 7, 8, "Samsung Smart TV 50 Polegadas com Processador Crystal 4K, Tela sem limites, Visual Livre de Cabos e Alexa integrada\r\nCom design simples e visual livre de cabos, sua nova Smart TV 50 Polegada vai ser a Samsung Crystal 4K\r\n\r\nCom organização e elegância, a Samsung Smart TV 50 Polegadas possui sitema de organização de cabos que ficam ligados à TV que ficam ocultos dentro das canaletas localizadas atrás da TV, que permite um visual mais limpo e clean.", null, "Smart Tv Sansung 50 polegadas UHD 4K", 2400f },
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
                name: "IX_ImagensProdutos_ProdutoId",
                table: "ImagensProdutos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCarrinho_ProdutoId",
                table: "ItemCarrinho",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCarrinho_UsuarioId",
                table: "ItemCarrinho",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favoritos");

            migrationBuilder.DropTable(
                name: "ImagensProdutos");

            migrationBuilder.DropTable(
                name: "ItemCarrinho");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
