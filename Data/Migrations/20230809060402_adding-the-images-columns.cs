using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addingtheimagescolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ImagemPrincipal",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4", "ImagemPrincipal" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4", "ImagemPrincipal" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4", "ImagemPrincipal" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4", "ImagemPrincipal" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4", "ImagemPrincipal" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4", "ImagemPrincipal" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Imagem1", "Imagem2", "Imagem3", "Imagem4", "ImagemPrincipal" },
                values: new object[] { null, null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ImagemPrincipal",
                table: "Produto");
        }
    }
}
