using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaDesarrolloDeadlockCore.Migrations
{
    public partial class Add_DireccionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Posicións_PosicionId",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posicións",
                table: "Posicións");

            migrationBuilder.RenameTable(
                name: "Posicións",
                newName: "Posiciones");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Empleados",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "DireccionId",
                table: "Empleados",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmpleadoDocumento",
                table: "Empleados",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDeNacimiento",
                table: "Empleados",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posiciones",
                table: "Posiciones",
                column: "PosicionId");

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    DireccionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion1 = table.Column<string>(maxLength: 100, nullable: false),
                    Direccion2 = table.Column<string>(maxLength: 100, nullable: false),
                    NumeroDeCasa = table.Column<int>(nullable: false),
                    Pais = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.DireccionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DireccionId",
                table: "Empleados",
                column: "DireccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Direccion_DireccionId",
                table: "Empleados",
                column: "DireccionId",
                principalTable: "Direccion",
                principalColumn: "DireccionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Posiciones_PosicionId",
                table: "Empleados",
                column: "PosicionId",
                principalTable: "Posiciones",
                principalColumn: "PosicionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Direccion_DireccionId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Posiciones_PosicionId",
                table: "Empleados");

            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_DireccionId",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posiciones",
                table: "Posiciones");

            migrationBuilder.DropColumn(
                name: "DireccionId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "EmpleadoDocumento",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "FechaDeNacimiento",
                table: "Empleados");

            migrationBuilder.RenameTable(
                name: "Posiciones",
                newName: "Posicións");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posicións",
                table: "Posicións",
                column: "PosicionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Posicións_PosicionId",
                table: "Empleados",
                column: "PosicionId",
                principalTable: "Posicións",
                principalColumn: "PosicionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
