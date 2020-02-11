using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoLivrariaCore.Migrations
{
    public partial class removeRequiredCapa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "CapaLivro",
                table: "Livro",
                nullable: true,
                oldClrType: typeof(byte[]));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "CapaLivro",
                table: "Livro",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }
    }
}
