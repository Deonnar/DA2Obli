using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using TodoPagos.LogicaRepositorio;
using TodoPagos.Dominio.Entidades.Usuarios;

namespace TodoPagos.Seguridad
{
    public static class ValidarAcceso
    {
        public static Boolean TieneAccesso(HttpRequestMessage request)
        {
            IEnumerable<String> nombreUsuario;
            request.Headers.TryGetValues("NOMBRE_USUARIO", out nombreUsuario);

            if (nombreUsuario == null)
            {
                throw new Exception("Usuario no encontrado");
            }
            else
            {
                if (esAdministrador(nombreUsuario.First())){
                    return true;
                }else if (esCajero(nombreUsuario.First())){
                    throw new Exception("El usuario no tiene acceso");
                }
                else
                {
                    throw new Exception("Usuario no encontrado!");
                }
            }
        }

        private static Boolean esAdministrador(String nombreUsuario)
        {
            Administrador admin = RepositorioAdministrador.ObtenerAdministradorPorNombreUsuario(nombreUsuario);
            return (admin != null);
        }

        private static Boolean esCajero(String nombreUsuario)
        {
            Cajero cajero = RepositorioCajeros.ObtenerCajeroPorNombreUsuario(nombreUsuario);
            return (cajero != null);
        }
    }
}
