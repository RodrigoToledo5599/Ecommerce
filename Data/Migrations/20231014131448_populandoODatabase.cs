using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class populandoODatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 14, "Computador" },
                    { 15, "Notebook" },
                    { 16, "Console Video Game" },
                    { 17, "Memoria Ram" }
                });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Smart TV 70 Polegadas Samsung UHD 4K, 3 HDMI, 1 USB, Bluetooth, Wi-Fi, Gaming Hub", 3500f });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "CategoriaId", "Descricao", "ImagemPrincipal", "Name", "Price" },
                values: new object[,]
                {
                    { 17, 11, null, null, "Mouse Gamer Redragon Cobra, Chroma RGB, 12400DPI, 7 Botões, Preto", 109f },
                    { 18, 4, null, null, "Smartphone Motorola Moto E13, 64GB, 4GB RAM, Octa Core, Câmera 13MP, Tela de 6.5, Grafite", 770f },
                    { 20, 7, null, null, "Processador AMD Ryzen 7 5700X, 3.4GHz (4.6GHz Max Turbo), Cache 36MB, AM4", 1240f },
                    { 21, 12, null, null, "SSD 480 GB Adata Ultimate SU650, Leitura: 550MB/s e Gravação: 510MB/s", 130f },
                    { 22, 8, null, null, "Smart TV 32 Polegadas AOC Roku HD LED, 3 HDMI, 1 USB, Wi-Fi", 930f },
                    { 16, 16, null, null, "Console Sony PlayStation 5 + Jogo EA Sports FC 24\r\nSony\r\n(0)\r\n", 3905f },
                    { 19, 17, null, null, "Memória Gamer Husky Gaming Avalanche, 16GB, 3200MHz, DDR4", 200f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Tv", 3000f });
        }
    }
}
