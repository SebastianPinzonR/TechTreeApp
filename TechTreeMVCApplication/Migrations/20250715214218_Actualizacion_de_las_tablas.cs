using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechTreeMVCApplication.Migrations
{
    /// <inheritdoc />
    public partial class Actualizacion_de_las_tablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "CategoriasItem");

            migrationBuilder.DropColumn(
                name: "TipodeMedioId",
                table: "CategoriasItem");

            migrationBuilder.AddColumn<int>(
                name: "TipoUsuarioId",
                table: "TipodeUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "TipodeUsuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "CategoriasItem",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaItemId",
                table: "CategoriasItem",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Categorias",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "usuariosdelaAplicacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Direccion1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Direccion2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CodigoPostal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosdelaAplicacion", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipodeUsuario_TipoUsuarioId",
                table: "TipodeUsuario",
                column: "TipoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasItem_CategoriaItemId",
                table: "CategoriasItem",
                column: "CategoriaItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasItem_Categorias_CategoriaItemId",
                table: "CategoriasItem",
                column: "CategoriaItemId",
                principalTable: "Categorias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriasItem_TipodeMedio_CategoriaItemId",
                table: "CategoriasItem",
                column: "CategoriaItemId",
                principalTable: "TipodeMedio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TipodeUsuario_Categorias_TipoUsuarioId",
                table: "TipodeUsuario",
                column: "TipoUsuarioId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasItem_Categorias_CategoriaItemId",
                table: "CategoriasItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriasItem_TipodeMedio_CategoriaItemId",
                table: "CategoriasItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TipodeUsuario_Categorias_TipoUsuarioId",
                table: "TipodeUsuario");

            migrationBuilder.DropTable(
                name: "usuariosdelaAplicacion");

            migrationBuilder.DropIndex(
                name: "IX_TipodeUsuario_TipoUsuarioId",
                table: "TipodeUsuario");

            migrationBuilder.DropIndex(
                name: "IX_CategoriasItem_CategoriaItemId",
                table: "CategoriasItem");

            migrationBuilder.DropColumn(
                name: "TipoUsuarioId",
                table: "TipodeUsuario");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TipodeUsuario");

            migrationBuilder.DropColumn(
                name: "CategoriaItemId",
                table: "CategoriasItem");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "CategoriasItem",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "CategoriasItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipodeMedioId",
                table: "CategoriasItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }
    }
}
