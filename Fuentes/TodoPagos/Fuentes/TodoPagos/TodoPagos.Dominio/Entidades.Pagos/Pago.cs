using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TodoPagos.Dominio.Entidades.Proveedores;

namespace TodoPagos.Dominio.Entidades.Pagos
{
    [Table("Pagos")]
    public class Pago
    {
        [Key]
        [Column("ID")]
        public int PagoId { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public DateTime FechaEmision { get; set; }

        //public TipoPago TipoPago { get; set; }
  
        public long ImporteFactura { get; set; }

        public bool EstaPaga { get; set; }     

        public Proveedor Proveedor { get; set; }

        public Cliente Cliente { get; set; }
    }
}
