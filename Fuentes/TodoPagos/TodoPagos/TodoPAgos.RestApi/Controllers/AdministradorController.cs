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
    public class AdministradorController : ApiController
    {
        public AdministradorController() { }

        // GET api/values

        [Route("api/Administradores")]
        [HttpGet]
        public IEnumerable<Administrador> Get()
        {
            IEnumerable<Administrador> listaAdministradores = RepositorioAdministrador.ObtenerAdministradores();
            return listaAdministradores;
        }

        // GET api/<controller>/11
        public IHttpActionResult Get(int id)
        {
            try
            {
                Administrador usuario = RepositorioAdministrador.ObtenerAdministrador(id);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Administrador usuario)
        {
            try
            {
                RepositorioAdministrador.AgregarAdministrador(usuario);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Administrador usuario)
        {
            try
            {
                RepositorioAdministrador.Modificar(id, usuario);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("api/Administradores/{id}")]
        public IHttpActionResult Delete(int id)
        {
            if(RepositorioAdministrador.ObtenerAdministrador(id) != null)
            {
                RepositorioAdministrador.EliminarAdministrador(id);
                return Ok("Se ha eliminado el administrador " + id + " correctamente");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
