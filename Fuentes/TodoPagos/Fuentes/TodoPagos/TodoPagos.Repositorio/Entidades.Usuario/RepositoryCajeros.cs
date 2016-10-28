using System;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Repositorio.Contexto;

namespace TodoPagos.Repositorio.Entidades.Usuario
{
    public class RepositoryCajeros : IRepositoryCajeros
    {
        private Repository<Administrador> repositorio;

        public RepositoryCajeros(ContextoTodoPagos contexto)
        {
        }

        public void AgregarCajero(Administrador cajero)
        {
            repositorio.Agregar(cajero);
        }
        
        public Administrador ObtenerCajero(Administrador cajero)
        {
            return repositorio.Obtener(cajero);
        }

        public void BorrarCajero(Administrador cajero)
        {
            repositorio.Borrar(cajero);
        }

        public void ActualizarCajero(Administrador cajero)
        {
            repositorio.Actualizar(cajero);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
