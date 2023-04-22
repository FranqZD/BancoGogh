using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace BancoGogh.Shared.Models;


public  class Historial
{
    
    [Key]
    public int NoHistorial { get; set; }

    public double Abono { get; set; }

    public int NoPagoActual { get; set; }

    public string FechaAbono { get; set; } = null!;

    public string FechaLiquidacion { get; set; } = null!;

    public int FolioPrestamo { get; set; }

    public int Categoria { get; set; }

}
