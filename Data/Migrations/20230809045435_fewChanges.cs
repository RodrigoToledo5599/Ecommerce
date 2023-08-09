using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class fewChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Category_CategoriaId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoriaId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoriaId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoriaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoriaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategoriaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 7,
                column: "CategoriaId",
                value: 8);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoriaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoriaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoriaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoriaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategoriaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 7,
                column: "CategoriaId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Category_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
