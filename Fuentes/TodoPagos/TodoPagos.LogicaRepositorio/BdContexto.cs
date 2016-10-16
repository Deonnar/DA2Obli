using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TodoPagos.Dominio;


namespace TodoPagos.Dominio
{
    public class BdContexto: DbContext
    {
        private static BdContexto contexto;
        public DbSet<TodoPagos.Dominio.Entidades.Usuarios.Usuario> Usuarios { get; set; }
       // public DbSet<TodoPagos.Dominio.Entidades.Pagos.Factura> Facturas { get; set; }
      
        //  public DbSet<TodoPagos.Dominio.Entidades.Proveedores.Proveedor> Proveedores { get; set; }

        public static BdContexto GetInstance()
        {
            if (contexto == null)
            {
                contexto = new BdContexto();
            }

            return contexto;
        }
    }
}
