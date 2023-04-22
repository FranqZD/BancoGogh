using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;

public  class CategoriaDelPrestamo
{
    [Key]
    public int IdCategoria { get; set; }

    public double Cantidad { get; set; }

    public virtual ICollection<Historial> Historials { get; } = new List<Historial>();
}
