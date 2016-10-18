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
        long importeFactura = Int32.MinValue;
        long importePago = Int32.MinValue;
       
        public long ImporteFactura
        {  
         get
            {
                return importeFactura;
            }
            set
            {
                if (value > importePago)
                {
                    importeFactura = value;
                }
                else
                {
                    throw new System.ArgumentException("El importe debe menor o igual a lo pagado");
                }
            }
        
        
        }
        
        public long ImportePago { 
             get
            {
                return importePago;
            }
            set
            {
                if (value < importeFactura)
                {
                    importePago = value;
                }
                else
                {
                    throw new System.ArgumentException("El importe pago debe menor o igual al importe de la factura");
                }
            }
         }

        public Proveedor Proveedor { get; set; }

        public Cliente Cliente { get; set; }
    }
}
