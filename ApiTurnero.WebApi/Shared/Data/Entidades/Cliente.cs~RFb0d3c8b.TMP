using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTurnero.WebApi.Comunes.Data.Entidades
{
    [Index(nameof(Nombre), Name = "UQ_Cliente_NombreCliente", IsUnique = true)]
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [MaxLength(15, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio.")]
        [MaxLength(15, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Apellido { get; set; }

        public int telefono { get; set; }
    

        public List <Turno> Turnos { get; set; }

    }
}
