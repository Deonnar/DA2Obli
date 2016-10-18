using TodoPagos.Dominio.Entidades.Usuarios;

namespace TodoPagos.Repositorio.Entidades.Usuario
{
    public interface IRepositoryAdministrador
    {
        void AgregarAdministrador(Administrador administrador);

        Administrador ObtenerAdministrador(Administrador administrador);

        void BorrarCajero(Administrador administrador);

        void ActualizarCajero(Administrador administrador);
    }
}
