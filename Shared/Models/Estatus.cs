using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;



public  class Estatus
{
    [Key]
    public int IdEstado { get; set; }

    public string Estado { get; set; } = null!;
}
