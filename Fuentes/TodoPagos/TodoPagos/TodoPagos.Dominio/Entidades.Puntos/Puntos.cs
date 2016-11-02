using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TodoPagos.Dominio.Entidades.Pagos.Cliente;

namespace TodoPagos.Dominio.Entidades.Puntos
{
    public class Puntos
    {
        [Key]
        [Column("ID")]
        public int PuntosId { get; set; }
        public string ValorPunto { get; set; }

        public List<Pago> listaPagos { get; set; }
    }
}
