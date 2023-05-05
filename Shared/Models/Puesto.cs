using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;

public  class Puesto
{

    [Key]
    public int IdPuesto { get; set; }
    public string? Puesto1 { get; set; }

}
