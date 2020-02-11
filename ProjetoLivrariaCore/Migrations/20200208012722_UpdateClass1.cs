using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoLivrariaCore.Migrations
{
    public partial class UpdateClass1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pathCapaLivro",
                table: "Livro",
                newName: "PathCapaLivro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PathCapaLivro",
                table: "Livro",
                newName: "pathCapaLivro");
        }
    }
}
