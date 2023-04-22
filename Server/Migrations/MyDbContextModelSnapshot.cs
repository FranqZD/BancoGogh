﻿// <auto-generated />
using System;
using BancoGogh.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BancoGogh.Server.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BancoGogh.Shared.Models.CategoriaDelPrestamo", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"));

                    b.Property<double>("Cantidad")
                        .HasColumnType("float");

                    b.HasKey("IdCategoria");

                    b.ToTable("CategoriaDelPrestamo");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Cuenta", b =>
                {
                    b.Property<int>("Id_Cuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Cuenta"));

                    b.Property<int>("Id_Empleado")
                        .HasColumnType("int");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Cuenta");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Empleado", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpleado"));

                    b.Property<string>("ApMPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApPPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstatusPrestamo")
                        .HasColumnType("int");

                    b.Property<string>("FeNacPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FecInicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FolioPrestamo")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Nomina")
                        .HasColumnType("bigint");

                    b.Property<int>("Puesto")
                        .HasColumnType("int");

                    b.Property<int>("PuestoNavigationIdPuesto")
                        .HasColumnType("int");

                    b.Property<string>("Vac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEmpleado");

                    b.HasIndex("PuestoNavigationIdPuesto");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Estatus", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstado"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEstado");

                    b.ToTable("Estatuses");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Historial", b =>
                {
                    b.Property<int>("NoHistorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoHistorial"));

                    b.Property<double>("Abono")
                        .HasColumnType("float");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaDelPrestamoIdCategoria")
                        .HasColumnType("int");

                    b.Property<string>("FechaAbono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaLiquidacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FolioPrestamo")
                        .HasColumnType("int");

                    b.Property<int>("NoPagoActual")
                        .HasColumnType("int");

                    b.HasKey("NoHistorial");

                    b.HasIndex("CategoriaDelPrestamoIdCategoria");

                    b.ToTable("Historials");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Plazo", b =>
                {
                    b.Property<int>("IdPlazo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlazo"));

                    b.Property<double>("Intereses")
                        .HasColumnType("float");

                    b.Property<int>("Meses")
                        .HasColumnType("int");

                    b.HasKey("IdPlazo");

                    b.ToTable("Plazos");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Prestamo", b =>
                {
                    b.Property<int>("FolioPrestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FolioPrestamo"));

                    b.Property<int>("CantidadPrestamo")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoIdEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("FecAprobacionPrestamo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FecSolicitudPrestamo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int?>("PlazoIdPlazo")
                        .HasColumnType("int");

                    b.Property<int>("Plazos")
                        .HasColumnType("int");

                    b.HasKey("FolioPrestamo");

                    b.HasIndex("EmpleadoIdEmpleado");

                    b.HasIndex("PlazoIdPlazo");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Puesto", b =>
                {
                    b.Property<int>("IdPuesto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPuesto"));

                    b.Property<string>("Puesto1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPuesto");

                    b.ToTable("Puestos");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Rifa", b =>
                {
                    b.Property<int>("NoBoleto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoBoleto"));

                    b.Property<string>("CuentaBol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FechaBoleto")
                        .HasColumnType("bigint");

                    b.HasKey("NoBoleto");

                    b.ToTable("Rifas");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("ApMPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApPPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurpUsr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstatusPrestamo")
                        .HasColumnType("int");

                    b.Property<string>("FeNacPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FolioPrestamo")
                        .HasColumnType("int");

                    b.Property<int>("IdHistorial")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SaldoUsr")
                        .HasColumnType("float");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Empleado", b =>
                {
                    b.HasOne("BancoGogh.Shared.Models.Puesto", "PuestoNavigation")
                        .WithMany("Empleados")
                        .HasForeignKey("PuestoNavigationIdPuesto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PuestoNavigation");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Historial", b =>
                {
                    b.HasOne("BancoGogh.Shared.Models.CategoriaDelPrestamo", null)
                        .WithMany("Historials")
                        .HasForeignKey("CategoriaDelPrestamoIdCategoria");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Prestamo", b =>
                {
                    b.HasOne("BancoGogh.Shared.Models.Empleado", null)
                        .WithMany("Prestamos")
                        .HasForeignKey("EmpleadoIdEmpleado");

                    b.HasOne("BancoGogh.Shared.Models.Plazo", null)
                        .WithMany("Prestamos")
                        .HasForeignKey("PlazoIdPlazo");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.CategoriaDelPrestamo", b =>
                {
                    b.Navigation("Historials");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Empleado", b =>
                {
                    b.Navigation("Prestamos");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Plazo", b =>
                {
                    b.Navigation("Prestamos");
                });

            modelBuilder.Entity("BancoGogh.Shared.Models.Puesto", b =>
                {
                    b.Navigation("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
