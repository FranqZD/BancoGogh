using System;
using System.ComponentModel.DataAnnotations;


namespace BancoGogh.Shared.Models;
public class Status
{
    public int StatusCode{get;set;}
    public string Message{get;set;}
}