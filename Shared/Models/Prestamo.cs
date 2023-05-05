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

    public string FecUltimoPagoPrestamo {get;set;} = "22/04/2023";

    public int IdUsuario { get; set; }


    [Required(ErrorMessage = "El campo Plazos es obligatorio.")]
    public int Plazos { get; set; }

    public int IdEmpleado { get; set; }
    
}
