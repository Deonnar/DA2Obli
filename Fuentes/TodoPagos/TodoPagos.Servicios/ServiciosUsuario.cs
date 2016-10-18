using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Repositorio;

namespace TodoPagos.Servicios
{
    public class ServiciosUsuario: IServiciosUsuarios
    {
        private readonly IUnitOfWork unitOfWork;
        /// <summary>
        /// ver
        /// </summary>
        public ServiciosUsuario()
        {
        //    this.unitOfWork = new UnitOfWork();
        }

        public ServiciosUsuario(IUnitOfWork unit)
        {
            this.unitOfWork = unit;
        }
        public Usuario ObtenerUsuario(int IdUsuario) {
            Usuario u = new Usuario();
            u.Nombre = "Juan";
            AgregarUsuario(u);
            return unitOfWork.RepositorioUsuario.Obtener(IdUsuario);
        }
       /* public IEnumerable<Usuario> ObtenerUsuarios() {
            return unitOfWork.RepositorioUsuario.ObtenerLista(null, null, "");
        }*/

        public int AgregarUsuario(Usuario usuario) {
            unitOfWork.RepositorioUsuario.Agregar(usuario);
            unitOfWork.Save();
            return usuario.UsuarioId;
        }
        public bool ModificarUsuario(int IdUsuario, Usuario usuario) {
            if (ExisteUsuario(IdUsuario))
            {
                Usuario usuarioRecuperado = unitOfWork.RepositorioUsuario.Obtener(IdUsuario);
                usuarioRecuperado.Nombre = usuario.Nombre;
                usuarioRecuperado.Direccion = usuario.Direccion;
                usuarioRecuperado.Apellido = usuario.Apellido;
                usuarioRecuperado.Cedula = usuario.Cedula;
                unitOfWork.RepositorioUsuario.Actualizar(usuarioRecuperado);
                unitOfWork.Save();
                return true;
            }
            return false;

        }

        public bool BorrarUsuario(int IdUsuario) {
            if (ExisteUsuario(IdUsuario))
            {
                unitOfWork.RepositorioUsuario.Borrar(IdUsuario);
                unitOfWork.Save();
                return true;
            }
            return false;
        }

        private bool ExisteUsuario(int IdUsuario)
        {
            Usuario user = unitOfWork.RepositorioUsuario.Obtener(IdUsuario);
            return user != null;
        }


    }
}
