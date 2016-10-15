using System;
using TodoPagos.LogicaNegocio.Entidades.Proveedores;

namespace TodoPagos.Repositorio.Entidades.Proveedores
{
    public class RepositoryProveedores : IRepositoryProveedores
    {
        private Repository<Proveedor> repositorio;

        public RepositoryProveedores()
        {

        }

        public void AgregarProveedor(Proveedor proveedor)
        {
            repositorio.Agregar(proveedor);
        }

        public Proveedor ObtenerProveedor(Proveedor proveedor)
        {
            return repositorio.Obtener(proveedor);
        }

        public void BorrarProveedor(Proveedor proveedor)
        {
            repositorio.Borrar(proveedor);
        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            repositorio.Actualizar(proveedor);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
