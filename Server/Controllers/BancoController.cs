using Microsoft.AspNetCore.Mvc;
using BancoGogh.Server.Context;
using BancoGogh.Shared.Models;

namespace BancoGogh.Server.Controllers;

[Route("api/[controller]/[action]")]

[ApiController]

public class BancoController : ControllerBase
{
    private readonly MyDbContext _ctx;

    public BancoController(MyDbContext ctx)
    {
        _ctx = ctx;
    }


    //aqui se obtiene la lista de usuarios

    [HttpPost]
    public IActionResult AddUpdate(Usuario usuario)
    {
        var status = new Status();
        if (!ModelState.IsValid)
        {
            status.StatusCode = 0;
            status.Message = "Please pass the valid data";
            return Ok(status);
        }
        try
        {
            if (usuario.IdUsuario == 0)
                _ctx.Usuarios.Add(usuario);
            else
                _ctx.Usuarios.Update(usuario);
            _ctx.SaveChanges();
            status.StatusCode = 1;
            status.Message = "Saved successfully";

        }
        catch (Exception ex)
        {
            status.StatusCode = 0;
            status.Message = "Server error";
        }
        return Ok(status);
    }

 [HttpPost]
    public IActionResult AddPrestamo(Prestamo prestamo)
    {
        var status = new Status();
        if (!ModelState.IsValid)
        {
            status.StatusCode = 0;
            status.Message = "Please pass the valid data";
            return Ok(status);
        }
        try
        {
            if (prestamo.FolioPrestamo == 0)
                _ctx.Prestamos.Add(prestamo);
            else
                _ctx.Prestamos.Update(prestamo);
            _ctx.SaveChanges();
            status.StatusCode = 1;
            status.Message = "Saved successfully";

        }
        catch (Exception ex)
        {
            status.StatusCode = 0;
            status.Message = "Server error";
        }
        return Ok(status);
    }

[HttpPost]
    public IActionResult GetById(Usuario u)
    {
        var usuario = _ctx.Usuarios.FirstOrDefault(x => x.CurpUsr == u.CurpUsr && x.Contrasenia == u.Contrasenia);

        if (usuario == null)
        {
            return BadRequest(new { message = "CURP o contraseña incorrectos" });
        }

        return Ok(usuario);
    }

    [HttpGet]
        public ActionResult GetAll(string sTerm = "", int pageNo = 1)
        {
            sTerm = sTerm.ToLower();
            var data = (from person in _ctx.Usuarios
                        where sTerm == null || person.CurpUsr.ToLower().StartsWith(sTerm)
                        select new Usuario
                        {
                            IdUsuario = person.IdUsuario,
                           
                        }
                        ).ToList();
            var totalRecords = data.Count;
            int pageSize = 3;
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            int skip = (pageNo - 1) * pageSize;
            data = data.Skip(skip).Take(pageSize).ToList();
            var model = new UsuarioList
            {
                //esto es lo que se envia al cliente
            
            };

            return Ok(model);
        }

    }

    


