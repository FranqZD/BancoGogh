using Microsoft.EntityFrameworkCore;
using BancoGogh.Shared.Models;

namespace BancoGogh.Server.Context;

public class MyDbContext : DbContext
{
           public MyDbContext(DbContextOptions<MyDbContext> options)
                : base(options)
        {
        }
    public DbSet<CategoriaDelPrestamo> CategoriaDelPrestamo { get; set; }
    // se pone las entidades en cada dbset
    public DbSet<Cuenta> Cuentas { set; get; }
    public DbSet<Empleado> Empleados { get; set; }
    public DbSet<Estatus> Estatuses { get; set; }
    public DbSet<Historial> Historials { get; set; }
    public DbSet<Plazo> Plazos { get; set; }
    public DbSet<Prestamo> Prestamos { get; set; }
    public DbSet<Puesto> Puestos { get; set; }
    public DbSet<Rifa> Rifas { get; set; }
    public DbSet<Usuario> Usuarios { set; get; }


}