using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;


public  class DatosPersonales
{
    [Key]
    public int IdPersona { get; set; }

    public string NombrePersona { get; set; } = null!;

    public string ApPPersona { get; set; } = null!;

    public string ApMPersona { get; set; } = null!;

    public string FeNacPersona { get; set; } = null!;

    public int EstatusPrestamo { get; set; }

    public string Empleado { get; set;} = null;

    public string Usuarios { get; set; }  = null;

    public int Tipo { get; set; }

    public virtual Empleado EmpleadoNavigation { get; set; } = null!;

    public virtual Estatus EstatusPrestamoNavigation { get; set; } = null!;

    public virtual Usuario UsuariosNavigation { get; set; } = null!;
}
