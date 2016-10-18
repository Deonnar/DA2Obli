using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Proveedores;

namespace TodoPagos.Dominio.Entidades.Pagos
{
    public class CamposFactura
    {
        public int CamposFacturaId { get; set; }
        public Proveedor Proveedor { get; set; }
        public string Descripcion { get; set; }
    }
}
