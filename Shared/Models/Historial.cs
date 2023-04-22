using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace BancoGogh.Shared.Models;


public  class Historial
{
    //data annotations
    
    [Key]

    public int NoHistorial { get; set; }

    [Required(ErrorMessage = "El campo Abono es obligatorio.")]
    [Range(1, 1000000000, ErrorMessage = "El campo Abono debe ser mayor a 0.")]
    [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "El campo Abono debe ser un número con máximo 2 decimales.")]

    public double Abono { get; set; }


    [Required(ErrorMessage = "El campo NoPago es obligatorio.")]
    [Range(1, 1000000000, ErrorMessage = "El campo NoPago debe ser mayor a 0.")]
    [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "El campo NoPago debe ser un número con máximo 2 decimales.")]

    public int NoPagoActual { get; set; }

    [Required(ErrorMessage = "El campo Fecha abono es obligatorio.")]
    [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "El campo Fecha abono debe ser una fecha con formato yyyy-mm-dd.")]

    public string FechaAbono { get; set; } = null!;

    [Required(ErrorMessage = "El campo Fecha liquidación es obligatorio.")]
    [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "El campo Fecha liquidación debe ser una fecha con formato yyyy-mm-dd.")]
    public string FechaLiquidacion { get; set; } = null!;

    public int FolioPrestamo { get; set; }

    public int Categoria { get; set; }

}
