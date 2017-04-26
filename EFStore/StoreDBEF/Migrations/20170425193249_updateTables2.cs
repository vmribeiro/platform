using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace StoreDBEF.Migrations
{
    public partial class updateTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_InfoUsuario_Usuario_UsuarioId", table: "InfoUsuario");
            migrationBuilder.DropForeignKey(name: "FK_Telefone_InfoUsuario_InfoUsuarioId", table: "Telefone");
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
