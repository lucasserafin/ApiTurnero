using ApiTurnero.WebApi.Comunes.Data;
using ApiTurnero.WebApi.Comunes.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTurnero.WebApi.Server.Controllers
{
    [ApiController]
    [Route("api/turnos")]
    public class TurnosController : ControllerBase
    {
        private readonly dbContext context;

        public TurnosController(dbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<List<Turno>> Get()
        {
            return context.Turnos.Include(x => x.Cliente).ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Turno> Get(int id)
        {
            var turno = context.Turnos.Where(x => x.Id == id).Include(x => x.Cliente).FirstOrDefault();
            if (turno == null)
            {
                return NotFound($"No existe la turno con id igual a {id}.");
            }
            return Ok(turno);
        }

        [HttpPost]
        public ActionResult<Turno> Post(Turno turno)
        {
            try
            {
                context.Turnos.Add(turno);
                context.SaveChanges();
                return turno;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Turno turno)
        {
            if (id != turno.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var campo = context.Turnos.Where(x => x.Id == id).FirstOrDefault();
            if (campo == null)
            {
                return NotFound("no existe la provincia a modificar.");
            }
            campo.Fecha = turno.Fecha;
            campo.Horario = turno.Horario;
            campo.ClienteId = turno.ClienteId;
            try
            {
                context.Turnos.Update(campo);
                context.SaveChanges();
                return Ok("Los datos han sido cambiados");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var turno = context.Turnos.Where(x => x.Id == id).FirstOrDefault();
            if (turno == null)
            {
                return NotFound($"No existe la provincia con id igual a {id}.");
            }

            try
            {
                context.Turnos.Remove(turno);
                context.SaveChanges();
                return Ok($"el turno {turno.sucursal} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
