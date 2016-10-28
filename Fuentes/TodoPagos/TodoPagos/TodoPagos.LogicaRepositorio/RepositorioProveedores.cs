using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Proveedores; 
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public class RepositorioProveedores
    {
       public static void Agregar(int IdProveedor)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Proveedor proveedor = contexto.Proveedores.Include("Proveedores").ToList().Find(p => p.ProveedorId == IdProveedor);
            contexto.SaveChanges();
        }

        public static IEnumerable<Proveedor> ObtenerProveedores()
        {
            Proveedor proveedor = new Proveedor();
            proveedor.NombreProveedor = "Proveedor1";
            AgregarProveedor(proveedor);
            BdContexto contexto = BdContexto.GetInstance();
            var proveedores = (from f in contexto.Proveedores
                            orderby f.ProveedorId
                            select f);
            return proveedores;
        }

        public static void AgregarProveedor(Proveedor unProveedor)
        {        
     
           BdContexto contexto = BdContexto.GetInstance();
           contexto.Proveedores.Add(unProveedor);
           contexto.SaveChanges();
      
          }

        public static Proveedor ObtenerProveedor(int idProveedor)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var facturas = (from f in contexto.Proveedores
                            where f.ProveedorId == idProveedor
                            orderby f.ProveedorId
                            select f);
            return facturas.First();
        }

        public static void Modificar(int id, Proveedor proveedor)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Proveedor aModificar = contexto.Proveedores.Single(p => p.ProveedorId == id);

            aModificar.NombreProveedor = proveedor.NombreProveedor;
            aModificar.Descripcion = proveedor.Descripcion;
            
            contexto.SaveChanges();
        }
    }
}
