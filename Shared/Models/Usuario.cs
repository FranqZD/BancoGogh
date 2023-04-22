using System;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;

public class Usuario
{

    [Key]
    public int IdUsuario { get; set; }
    public string NombrePersona { get; set; } = null!;
    public string ApPPersona { get; set; } = null!;
    public string ApMPersona { get; set; } = null!;
    public string FeNacPersona { get; set; } = null!;
    public string CurpUsr { get; set; } = null;
    
    public double SaldoUsr { get; set; } = 10000;
    public int IdHistorial { get; set; }
    public int EstatusPrestamo { get; set; }
    public int FolioPrestamo { get; set; }

}
