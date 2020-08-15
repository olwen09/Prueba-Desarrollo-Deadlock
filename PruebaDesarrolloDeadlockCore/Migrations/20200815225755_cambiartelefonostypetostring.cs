using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaDesarrolloDeadlockCore.Migrations
{
    public partial class cambiartelefonostypetostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefono2",
                table: "Empleados",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono1",
                table: "Empleados",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefono2",
                table: "Empleados",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Telefono1",
                table: "Empleados",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
