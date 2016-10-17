using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
 
namespace TodoPagos.Dominio.Entidades.Proveedores
{
    [Table("Proveedores")]
    public class Proveedor
    {
        [Key]
        [Column("ID")]
        public int ProveedorId { get; set; }

        public String NombreProveedor { get; set; }

    }
}
