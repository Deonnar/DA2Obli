using System;
using static TodoPagos.Dominio.Enumerados.Enumerados;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TodoPagos.Dominio.Entidades.Pagos
{
    [Table("Facturas")]
    public class Factura
    {
        [Key]
        [Column("ID")]
        public int FacturaId { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public DateTime FechaEmision { get; set; }

        public bool EstaPaga { get; set; }

        public TipoPago TipoPago { get; set; }

        public long Monto { get; set; }

        public Boolean EstaBorrado { get; set; }
    }
}
