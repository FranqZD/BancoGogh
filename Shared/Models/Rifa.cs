using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;

public  class Rifa
{

    [Key]
    public int NoBoleto { get; set; }
    public long FechaBoleto { get; set; }
    public string CuentaBol { get; set; }


}
