using System;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;

public class Usuario
{

    [Key]
    public int IdUsuario { get; set; }
    public string Contrasenia {get;set;} =null;
    public string CurpUsr { get; set; } = null;
    public double SaldoUsr { get; set; }
    public int IdHistorial { get; set; }

}
