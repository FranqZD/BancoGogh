using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoGogh.Shared.Models;

public class Cuenta
{
    //data annotations

    [Key]
    public int Id_Cuenta{get; set;}
    [Required,
    StringLength(10, ErrorMessage = "El campo Nombre debe tener máximo 10 caracteres."),
    RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "El campo Nombre debe ser alfanumérico."),
    MinLength(5, ErrorMessage = "El campo Nombre debe tener mínimo 5 caracteres.")]
    public string nickname {get;set;}

    [Required]

    public string password {get;set;} = null;

    public int Id_Usuario {get;set;} = 0;
    public int Id_Empleado {get;set;} = 0;
} 