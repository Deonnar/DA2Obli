using TodoPagos.LogicaNegocio.Entidades.Proveedores;

namespace TodoPagos.Repositorio.Entidades.Proveedores
{
    public interface IRepositoryProveedores
    {
        void AgregarProveedor(Proveedor proveedor);

        Proveedor ObtenerProveedor(Proveedor proveedor);

        void BorrarProveedor(Proveedor proveedor);

        void ActualizarProveedor(Proveedor proveedor);
    }
}
