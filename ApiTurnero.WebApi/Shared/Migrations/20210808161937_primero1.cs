using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiTurnero.WebApi.Comunes.Migrations
{
    public partial class primero1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropIndex(
                name: "UQ_Turno_N_sucursal",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "UQ_Cliente_CodCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DNI",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "N_sucursal",
                table: "Turnos",
                newName: "sucursal");

            migrationBuilder.CreateIndex(
                name: "UQ_Turno_sucursal",
                table: "Turnos",
                column: "sucursal",
                unique: true,
                filter: "[sucursal] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ_Cliente_NombreCliente",
                table: "Clientes",
                column: "Nombre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UQ_Turno_sucursal",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "UQ_Cliente_NombreCliente",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "sucursal",
                table: "Turnos",
                newName: "N_sucursal");

            migrationBuilder.AddColumn<int>(
                name: "DNI",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPais = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NombrePais = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodProvincia = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    NombreProvincia = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincias_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ_Turno_N_sucursal",
                table: "Turnos",
                column: "N_sucursal",
                unique: true,
                filter: "[N_sucursal] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ_Cliente_CodCliente",
                table: "Clientes",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_Pais_CodPais",
                table: "Paises",
                column: "CodPais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_PaisId",
                table: "Provincias",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "UQ_Provincia_CodProvincia",
                table: "Provincias",
                column: "CodProvincia",
                unique: true);
        }
    }
}
