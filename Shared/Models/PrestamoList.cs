using System;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;

public class PrestamoList
{
    public List<Prestamo>? PrestamosLista {get;set;}
}