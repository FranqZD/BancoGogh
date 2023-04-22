using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;

public  class Plazo
{
    [Key]
    public int IdPlazo { get; set; }

    [Required(ErrorMessage = "El campo Meses es obligatorio.")]
    [Range(1, 100, ErrorMessage = "El campo Meses debe ser mayor a 0")]

    public int Meses { get; set; }

    [Required(ErrorMessage = "El campo Intereses es obligatorio.")]
    [Range(1, 100, ErrorMessage = "El campo Intereses debe ser mayor a 0")]
    public double Intereses { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; } = new List<Prestamo>();
}
