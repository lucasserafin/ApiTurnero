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
    [Route("api/clientes")]
    public class ClientesController: ControllerBase
    {

        private readonly dbContext context;

        public ClientesController(dbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            return context.Clientes.Include(x => x.Turnos).ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Cliente> Get(int id)
        {
            var pais = context.Clientes.Where(x => x.Id == id).Include(x => x.Turnos).FirstOrDefault();
            if (pais == null)
            {
                return NotFound($"No existe el pais con id igual a {id}.");
            }
            return pais;
        }

        [HttpPost]
        public ActionResult<Cliente> Post(Cliente cliente)
        {
            try
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
                return cliente;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var campo = context.Clientes.Where(x => x.Id == id).FirstOrDefault();
            if (campo == null)
            {
                return NotFound("no existe el cliente a modificar.");
            }
         
            campo.Nombre = cliente.Nombre;
            try
            {
                context.Clientes.Update(campo);
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
            var cliente = context.Clientes.Where(x => x.Id == id).FirstOrDefault();
            if (cliente == null)
            {
                return NotFound($"No existe el cliente con id igual a {id}.");
            }

            try
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
                return Ok($"El país {cliente.Apellido} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
