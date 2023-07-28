using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class oqqjiowopq : Migration
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 14, "Computador" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoriaId", "Name" },
                values: new object[] { 8, "Tv 42 polegadas 4K" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoriaId", "Name" },
                values: new object[] { 4, "Celular galaxy S10" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoriaId", "Name" },
                values: new object[] { 14, "Pc Gamer ryzen 7 7700x, 3080ti" });

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
                value: 32);

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
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoriaId", "Name" },
                values: new object[] { null, "Tv" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoriaId", "Name" },
                values: new object[] { null, "Celular" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoriaId", "Name" },
                values: new object[] { null, "Pc Gamer" });

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
