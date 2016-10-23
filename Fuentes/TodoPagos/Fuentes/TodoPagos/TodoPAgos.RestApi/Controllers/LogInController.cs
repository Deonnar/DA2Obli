using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.LogicaRepositorio;

namespace TodoPAgos.RestApi.Controllers
{
    public class LogInController : ApiController
    {
        public IHttpActionResult Post([FromBody]Usuario datosLogin)
        {
            try
            {
                Usuario u = RepositorioLogin.ObtenerUsuarioPorUsername(datosLogin.NombreUsuario);
                if (u.Autorizado)
                {
                    return Ok(u);
                }
                else
                {
                    if (RepositorioLogin.AutentificarUsuario(datosLogin.NombreUsuario, datosLogin.Contrasenia, datosLogin.Token))

                        return Ok(u);
                    else
                        return NotFound();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
