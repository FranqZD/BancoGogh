using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;


public  class Empleado
{

    [Key]
    public int IdEmpleado { get; set; }

    public long Nomina { get; set; }

    public string Vac { get; set; } = null!;

    public string FecInicio { get; set; } = null!;

    public int Puesto { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; } = new List<Prestamo>();

    public virtual Puesto PuestoNavigation { get; set; } = null!;


}