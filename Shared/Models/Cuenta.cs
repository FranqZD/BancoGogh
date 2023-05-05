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
    
    public string nickname {get;set;}

    [Required]

    public string password {get;set;} = null;

    public int Id_Usuario {get;set;} = 0;
    public int Id_Empleado {get;set;} = 0;
} 