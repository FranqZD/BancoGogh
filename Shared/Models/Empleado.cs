using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;


public  class Empleado
{
    //data annotations

    [Key]
    public int IdEmpleado { get; set; }

    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    [StringLength(20, ErrorMessage = "El campo Nombre debe tener máximo 20 caracteres.")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "El campo Nombre debe ser alfabético.")]
    [MinLength(3, ErrorMessage = "El campo Nombre debe tener mínimo 3 caracteres.")]
    public string NombrePersona { get; set; } = null!;

    [Required(ErrorMessage = "El campo Apellido Paterno es obligatorio.")]
    [StringLength(20, ErrorMessage = "El campo Apellido Paterno debe tener máximo 20 caracteres.")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "El campo Apellido Paterno debe ser alfabético.")]
    [MinLength(3, ErrorMessage = "El campo Apellido Paterno debe tener mínimo 3 caracteres.")]

    public string ApPPersona { get; set; } = null!;


    [Required(ErrorMessage = "El campo Apellido Materno es obligatorio.")]
    [StringLength(20, ErrorMessage = "El campo Apellido Materno debe tener máximo 20 caracteres.")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "El campo Apellido Materno debe ser alfabético.")]
    [MinLength(3, ErrorMessage = "El campo Apellido Materno debe tener mínimo 3 caracteres.")]
    public string ApMPersona { get; set; } = null!;

    [Required(ErrorMessage = "El campo Fecha de nacimiento es obligatorio.")]
    
    public string FeNacPersona { get; set; } = null!;
    public long Nomina { get; set; }

    public string Vac { get; set; } = null!;

    public string FecInicio { get; set; } = null!;

    public int Puesto { get; set; }


    public int EstatusPrestamo { get; set; }

    public int FolioPrestamo { get; set; }


}
