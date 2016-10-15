using System;
using TodoPagos.LogicaNegocio.Entidades.Usuarios;
using TodoPagos.Repositorio.Contexto;

namespace TodoPagos.Repositorio.Entidades.Usuario
{
    public class RepositoryCajeros : IRepositoryCajeros
    {
        private Repository<Cajero> repositorio;

        public RepositoryCajeros(ContextoTodoPagos contexto)
        {
        }

        public void AgregarCajero(Cajero cajero)
        {
            repositorio.Agregar(cajero);
        }
        
        public Cajero ObtenerCajero(Cajero cajero)
        {
            return repositorio.Obtener(cajero);
        }

        public void BorrarCajero(Cajero cajero)
        {
            repositorio.Borrar(cajero);
        }

        public void ActualizarCajero(Cajero cajero)
        {
            repositorio.Actualizar(cajero);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
