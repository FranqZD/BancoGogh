using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;


public  class Prestamo
{
    [Key]
    public int FolioPrestamo { get; set; }

    [Required(ErrorMessage = "El campo Cantidad es obligatorio.")]
    [Range(1, 1000000000, ErrorMessage = "El campo Cantidad debe ser mayor a 0.")]
    [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "El campo Cantidad debe ser un número con máximo 2 decimales.")]
    public int CantidadPrestamo { get; set; }

    [Required(ErrorMessage = "El campo Fecha de solicitud es obligatorio.")]
    [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "El campo Fecha de solicitud debe ser una fecha con formato yyyy-mm-dd.")]
    public string FecSolicitudPrestamo { get; set; } = null!;

    [Required(ErrorMessage = "El campo Fecha de aprobación es obligatorio.")]
    [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "El campo Fecha de aprobación debe ser una fecha con formato yyyy-mm-dd.")]
    public string FecAprobacionPrestamo { get; set; } = null!;

    public string FecUltimoPagoPrestamo {get;set;} = "22/04/2023";

    public int IdUsuario { get; set; }


    [Required(ErrorMessage = "El campo Plazos es obligatorio.")]
    public int Plazos { get; set; }

    public int IdEmpleado { get; set; }
    
}
