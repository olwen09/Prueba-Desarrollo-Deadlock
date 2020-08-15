using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaDesarrolloDeadlockCore.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posicións",
                columns: table => new
                {
                    PosicionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosicionName = table.Column<string>(maxLength: 50, nullable: false),
                    Creacion = table.Column<DateTime>(nullable: false),
                    Modificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posicións", x => x.PosicionId);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(maxLength: 50, nullable: false),
                    ApellidoEmpleado = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Telefono1 = table.Column<int>(nullable: false),
                    Telefono2 = table.Column<int>(nullable: false),
                    Creacion = table.Column<DateTime>(nullable: false),
                    Modificacion = table.Column<DateTime>(nullable: false),
                    PosicionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleados_Posicións_PosicionId",
                        column: x => x.PosicionId,
                        principalTable: "Posicións",
                        principalColumn: "PosicionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PosicionId",
                table: "Empleados",
                column: "PosicionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Posicións");
        }
    }
}
