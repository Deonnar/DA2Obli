using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TodoPagos.Dominio.Entidades.Usuarios;


namespace TodoPagos.Dominio.Entidades.Log
{
    public class Historial
    {
        public int HistorialId { get; set; }
        public Boolean Accion { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Usuario { get; set; }
    }
}
