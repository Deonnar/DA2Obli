using System;
using TodoPagos.Dominio.Entidades.Usuarios;

namespace TodoPagos.Repositorio.Entidades.Usuario
{
    public class RepositoryAdministrador : IRepositoryAdministrador
    {
        private Repository<Administrador> repositorio;

        public RepositoryAdministrador()
        {
        }

        public void AgregarAdministrador(Administrador administrador)
        {
            repositorio.Agregar(administrador);
        }

        public Administrador ObtenerAdministrador(Administrador administrador)
        {
            return repositorio.Obtener(administrador);
        }

        public void BorrarCajero(Administrador administrador)
        {
            repositorio.Borrar(administrador);
        }

        public void ActualizarCajero(Administrador administrador)
        {
            repositorio.Actualizar(administrador);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
