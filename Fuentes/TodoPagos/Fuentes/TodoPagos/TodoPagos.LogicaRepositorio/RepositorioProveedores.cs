using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Proveedores;
using TodoPagos.LogicaNegocio;
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
          //  Proveedor proveedor = ObtenerProveedor(unProveedor.ProveedorId);
        //    if (proveedor != null)
            {
                BdContexto contexto = BdContexto.GetInstance();
                contexto.Proveedores.Add(unProveedor);
                contexto.SaveChanges();
            }
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
    }
}
