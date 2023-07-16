using Microsoft.EntityFrameworkCore.Migrations;

namespace Obligatorio_Prog_Nahuel_Alexis_Alejo.Migrations
{
    public partial class TableAdministradorDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroTrabajador",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NumeroTrabajador",
                table: "Personas",
                column: "NumeroTrabajador",
                unique: true,
                filter: "[NumeroTrabajador] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_NumeroTrabajador",
                table: "Personas",
                column: "NumeroTrabajador",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_NumeroTrabajador",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_NumeroTrabajador",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "NumeroTrabajador",
                table: "Personas");
        }
    }
}
