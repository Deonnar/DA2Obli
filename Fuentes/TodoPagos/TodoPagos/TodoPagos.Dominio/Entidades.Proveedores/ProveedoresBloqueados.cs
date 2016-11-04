using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TodoPagos.Dominio.Entidades.Proveedores
{
    [Table("ListaNegra")]
    public class ProveedoresBloqueados
    {
        [Key]
        [Column("ID")]
        public int ProveedorBloqueadoId { get; set; }

        public Proveedor Proveedor { get; set; }

        public String MotivoBloqueo { get; set; }

    }

}
