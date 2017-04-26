using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace StoreDBEF.Migrations
{
    public partial class createEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_InfoUsuario_Usuario_UsuarioId", table: "InfoUsuario");
            migrationBuilder.DropForeignKey(name: "FK_Telefone_InfoUsuario_InfoUsuarioId", table: "Telefone");
            migrationBuilder.DropColumn(name: "Endereco", table: "InfoUsuario");
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    InfoUsuarioId = table.Column<int>(nullable: false),
                    Rua = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_InfoUsuario_InfoUsuarioId",
                        column: x => x.InfoUsuarioId,
                        principalTable: "InfoUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "InfoUsuario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddForeignKey(
                name: "FK_InfoUsuario_Usuario_UsuarioId",
                table: "InfoUsuario",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_InfoUsuario_InfoUsuarioId",
                table: "Telefone",
                column: "InfoUsuarioId",
                principalTable: "InfoUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_InfoUsuario_Usuario_UsuarioId", table: "InfoUsuario");
            migrationBuilder.DropForeignKey(name: "FK_Telefone_InfoUsuario_InfoUsuarioId", table: "Telefone");
            migrationBuilder.DropColumn(name: "DataNascimento", table: "InfoUsuario");
            migrationBuilder.DropTable("Endereco");
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "InfoUsuario",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_InfoUsuario_Usuario_UsuarioId",
                table: "InfoUsuario",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_InfoUsuario_InfoUsuarioId",
                table: "Telefone",
                column: "InfoUsuarioId",
                principalTable: "InfoUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
