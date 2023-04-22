using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;

public  class CategoriaDelPrestamo
{

    //data annotations

    [Key]
    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    public int IdCategoria { get; set; }


    [Required(ErrorMessage = "El campo Cantidad es obligatorio.")]
    [Range(1, 1000000000, ErrorMessage = "El campo Cantidad debe ser mayor a 0.")]
    [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "El campo Cantidad debe ser un número con máximo 2 decimales.")]
    public double Cantidad { get; set; }

    public virtual ICollection<Historial> Historials { get; } = new List<Historial>();
}
