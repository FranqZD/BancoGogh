using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;


public  class Prestamo
{
    [Key]
    public int FolioPrestamo { get; set; }

    public int CantidadPrestamo { get; set; }

    public string FecSolicitudPrestamo { get; set; } = null!;

    public string FecAprobacionPrestamo { get; set; } = null!;

    public int IdUsuario { get; set; } = 0;

    public int Plazos { get; set; }

    public int IdEmpleado { get; set; } = 0;
    
}
