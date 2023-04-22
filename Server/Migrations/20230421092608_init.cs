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
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Datos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id_Cuenta);
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
                    Contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurpUsr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaldoUsr = table.Column<double>(type: "float", nullable: false),
                    IdHistorial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
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
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    CategoriaDelPrestamoIdCategoria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historials", x => x.NoHistorial);
                    table.ForeignKey(
                        name: "FK_Historials_CategoriaDelPrestamo_CategoriaDelPrestamoIdCategoria",
                        column: x => x.CategoriaDelPrestamoIdCategoria,
                        principalTable: "CategoriaDelPrestamo",
                        principalColumn: "IdCategoria");
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomina = table.Column<long>(type: "bigint", nullable: false),
                    Vac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FecInicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puesto = table.Column<int>(type: "int", nullable: false),
                    PuestoNavigationIdPuesto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleados_Puestos_PuestoNavigationIdPuesto",
                        column: x => x.PuestoNavigationIdPuesto,
                        principalTable: "Puestos",
                        principalColumn: "IdPuesto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatosPersonales",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApPPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApMPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeNacPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstatusPrestamo = table.Column<int>(type: "int", nullable: false),
                    Empleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    EmpleadoNavigationIdEmpleado = table.Column<int>(type: "int", nullable: false),
                    EstatusPrestamoNavigationIdEstado = table.Column<int>(type: "int", nullable: false),
                    UsuariosNavigationIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPersonales", x => x.IdPersona);
                    table.ForeignKey(
                        name: "FK_DatosPersonales_Empleados_EmpleadoNavigationIdEmpleado",
                        column: x => x.EmpleadoNavigationIdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatosPersonales_Estatuses_EstatusPrestamoNavigationIdEstado",
                        column: x => x.EstatusPrestamoNavigationIdEstado,
                        principalTable: "Estatuses",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatosPersonales_Usuarios_UsuariosNavigationIdUsuario",
                        column: x => x.UsuariosNavigationIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
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
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    Plazos = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    EmpleadoIdEmpleado = table.Column<int>(type: "int", nullable: true),
                    PlazoIdPlazo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.FolioPrestamo);
                    table.ForeignKey(
                        name: "FK_Prestamos_Empleados_EmpleadoIdEmpleado",
                        column: x => x.EmpleadoIdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado");
                    table.ForeignKey(
                        name: "FK_Prestamos_Plazos_PlazoIdPlazo",
                        column: x => x.PlazoIdPlazo,
                        principalTable: "Plazos",
                        principalColumn: "IdPlazo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_EmpleadoNavigationIdEmpleado",
                table: "DatosPersonales",
                column: "EmpleadoNavigationIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_EstatusPrestamoNavigationIdEstado",
                table: "DatosPersonales",
                column: "EstatusPrestamoNavigationIdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_UsuariosNavigationIdUsuario",
                table: "DatosPersonales",
                column: "UsuariosNavigationIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PuestoNavigationIdPuesto",
                table: "Empleados",
                column: "PuestoNavigationIdPuesto");

            migrationBuilder.CreateIndex(
                name: "IX_Historials_CategoriaDelPrestamoIdCategoria",
                table: "Historials",
                column: "CategoriaDelPrestamoIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_EmpleadoIdEmpleado",
                table: "Prestamos",
                column: "EmpleadoIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_PlazoIdPlazo",
                table: "Prestamos",
                column: "PlazoIdPlazo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "DatosPersonales");

            migrationBuilder.DropTable(
                name: "Historials");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Rifas");

            migrationBuilder.DropTable(
                name: "Estatuses");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CategoriaDelPrestamo");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Plazos");

            migrationBuilder.DropTable(
                name: "Puestos");
        }
    }
}
