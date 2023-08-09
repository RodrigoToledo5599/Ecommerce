using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ijjiorqiiq3rjoioq3jr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Category_CategoriaId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto");
        }
    }
}
