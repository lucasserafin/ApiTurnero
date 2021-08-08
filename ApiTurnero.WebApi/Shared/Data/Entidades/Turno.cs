using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiTurnero.WebApi.Comunes.Data.Entidades
{
    [Index(nameof(sucursal), Name = "UQ_Turno_CodTurno", IsUnique = true)]
    public class Turno
    {
        

        public int Id { get; set; }

        public string sucursal { get; set; }

        public int Fecha { get; set; }
       
        public int Horario { get; set; }

        

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
