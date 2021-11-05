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
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            //return await context.Clientes.Include(x => x.Turnos).ToListAsync();
            return await context.Clientes.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task < ActionResult<Cliente>> Get(int id)
        {
            var cliente = await context.Clientes.Where(x => x.Id == id).Include(x => x.Turnos).FirstOrDefaultAsync();
            if (cliente == null)
            {
                return NotFound($"No existe el cliente con id igual a {id}.");
            }
            return cliente;
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> Post(Cliente cliente)
        {
            try
            {
                context.Clientes.Add(cliente);
                await context.SaveChangesAsync();
                return cliente;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var campo = await context.Clientes.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (campo == null)
            {
                return NotFound("no existe el cliente a modificar.");
            }
         
            campo.Nombre = cliente.Nombre;
            campo.Apellido = cliente.Apellido;
            campo.Telefono = cliente.Telefono;
            try
            {
                context.Clientes.Update(campo);
                await context.SaveChangesAsync();
                return Ok("Los datos han sido cambiados");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var cliente = await context.Clientes.Where(x => x.Id == id).FirstOrDefaultAsync ();
            if (cliente == null)
            {
                return NotFound($"No existe el cliente con id igual a {id}.");
            }

            try
            {
                context.Clientes.Remove(cliente);
                await context.SaveChangesAsync();
                return Ok($"El país {cliente.Apellido} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
