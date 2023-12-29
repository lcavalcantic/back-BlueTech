using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace agenda.Migrations
{
    public partial class AtualizacaoAgenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos");

            migrationBuilder.RenameTable(
                name: "Contatos",
                newName: "tb_contatos");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "tb_contatos",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "tb_contatos",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_contatos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tb_contatos",
                newName: "name");

            migrationBuilder.UpdateData(
                table: "tb_contatos",
                keyColumn: "telefone",
                keyValue: null,
                column: "telefone",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "tb_contatos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tb_contatos",
                keyColumn: "email",
                keyValue: null,
                column: "email",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "tb_contatos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tb_contatos",
                keyColumn: "name",
                keyValue: null,
                column: "name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "tb_contatos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_contatos",
                table: "tb_contatos",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_contatos",
                table: "tb_contatos");

            migrationBuilder.RenameTable(
                name: "tb_contatos",
                newName: "Contatos");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Contatos",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Contatos",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Contatos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Contatos",
                newName: "Nome");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contatos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contatos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Contatos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos",
                column: "Id");
        }
    }
}
