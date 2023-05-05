using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoGogh.Server.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaDelPrestamo",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaDelPrestamo", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Id_Cuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    Id_Empleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id_Cuenta);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePersona = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ApPPersona = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ApMPersona = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FeNacPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nomina = table.Column<long>(type: "bigint", nullable: false),
                    Vac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FecInicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puesto = table.Column<int>(type: "int", nullable: false),
                    EstatusPrestamo = table.Column<int>(type: "int", nullable: false),
                    FolioPrestamo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "Estatuses",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estatuses", x => x.IdEstado);
                });

            migrationBuilder.CreateTable(
                name: "Historials",
                columns: table => new
                {
                    NoHistorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abono = table.Column<double>(type: "float", nullable: false),
                    NoPagoActual = table.Column<int>(type: "int", nullable: false),
                    FechaAbono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaLiquidacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FolioPrestamo = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historials", x => x.NoHistorial);
                });

            migrationBuilder.CreateTable(
                name: "Plazos",
                columns: table => new
                {
                    IdPlazo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Meses = table.Column<int>(type: "int", nullable: false),
                    Intereses = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plazos", x => x.IdPlazo);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    FolioPrestamo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadPrestamo = table.Column<int>(type: "int", nullable: false),
                    FecSolicitudPrestamo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FecAprobacionPrestamo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FecUltimoPagoPrestamo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    Plazos = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.FolioPrestamo);
                });

            migrationBuilder.CreateTable(
                name: "Puestos",
                columns: table => new
                {
                    IdPuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puesto1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puestos", x => x.IdPuesto);
                });

            migrationBuilder.CreateTable(
                name: "Rifas",
                columns: table => new
                {
                    NoBoleto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaBoleto = table.Column<long>(type: "bigint", nullable: false),
                    CuentaBol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rifas", x => x.NoBoleto);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApPPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApMPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeNacPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurpUsr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaldoUsr = table.Column<double>(type: "float", nullable: false),
                    IdHistorial = table.Column<int>(type: "int", nullable: false),
                    EstatusPrestamo = table.Column<int>(type: "int", nullable: false),
                    FolioPrestamo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaDelPrestamo");

            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Estatuses");

            migrationBuilder.DropTable(
                name: "Historials");

            migrationBuilder.DropTable(
                name: "Plazos");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Puestos");

            migrationBuilder.DropTable(
                name: "Rifas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
