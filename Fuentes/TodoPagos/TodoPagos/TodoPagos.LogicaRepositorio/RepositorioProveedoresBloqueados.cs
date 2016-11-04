using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Proveedores;
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public class RepositorioProveedoresBloqueados
    {
        public static void Agregar(int IdProveedor)
        {
            BdContexto contexto = BdContexto.GetInstance();
            ProveedoresBloqueados proveedor = contexto.ProveedoresBloqueados.Include("ProveedoresBloqueados").ToList().Find(p => p.ProveedorBloqueadoId == IdProveedor);
            contexto.SaveChanges();
        }

        public static IEnumerable<ProveedoresBloqueados> ObtenerProveedores()
        {
            BdContexto contexto = BdContexto.GetInstance();
            var proveedores = (from f in contexto.ProveedoresBloqueados
                               orderby f.ProveedorBloqueadoId
                               select f);
            return proveedores;
        }

        public static void AgregarProveedor(ProveedoresBloqueados unProveedor)
        {

            BdContexto contexto = BdContexto.GetInstance();
            contexto.ProveedoresBloqueados.Add(unProveedor);
            contexto.SaveChanges();

        }

        public static ProveedoresBloqueados ObtenerProveedor(int idProveedor)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var proveedoresBloqueados = (from p in contexto.ProveedoresBloqueados
                            where p.ProveedorBloqueadoId == idProveedor
                            orderby p.ProveedorBloqueadoId
                            select p);
            return proveedoresBloqueados.First();
        }

        /* static void Modificar(int id, ProveedoresBloqueados proveedor)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Proveedor aModificar = contexto.Proveedores.Single(p => p.ProveedorId == id);

            aModificar.NombreProveedor = proveedor.NombreProveedor;
            aModificar.Descripcion = proveedor.Descripcion;

            contexto.SaveChanges();
        }*/
    }
}
