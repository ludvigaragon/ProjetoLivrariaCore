using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoLivrariaCore.Migrations
{
    public partial class updateFieldCapa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CapaLivro",
                table: "Livro");

            migrationBuilder.AddColumn<string>(
                name: "pathCapaLivro",
                table: "Livro",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pathCapaLivro",
                table: "Livro");

            migrationBuilder.AddColumn<byte[]>(
                name: "CapaLivro",
                table: "Livro",
                nullable: true);
        }
    }
}
