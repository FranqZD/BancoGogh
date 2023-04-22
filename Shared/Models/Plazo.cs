using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;

public  class Plazo
{
    [Key]
    public int IdPlazo { get; set; }

    public int Meses { get; set; }

    public double Intereses { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; } = new List<Prestamo>();
}
