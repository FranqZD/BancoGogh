using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoGogh.Shared.Models;

public class Cuenta
{
    [Key]
    public int Id_Cuenta{get; set;}
    public string password {get;set;} = null;
    public int Id_Datos {get;set;} 
} 