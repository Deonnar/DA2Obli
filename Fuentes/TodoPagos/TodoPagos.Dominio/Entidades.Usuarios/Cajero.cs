using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TodoPagos.Dominio.Entidades.Usuarios
{
    public class Cajero : Usuario
    {
        //no seria la PK ? o solo un String?! unique?
       // public Guid NumeroIdentificacion { get; set; }
    }
}
