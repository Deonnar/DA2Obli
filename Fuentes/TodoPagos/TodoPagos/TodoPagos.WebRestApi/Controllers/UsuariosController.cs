using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TodoPagos.WebRestApi.Controllers
{
    public class UsuariosController : ApiController
    {
        public UsuariosController() { }
/*
        // GET api/values
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            IEnumerable<Usuario> listaUsuarios = RepositorioUsuarios.ObtenerUsuarios();
            return listaUsuarios;
        }

        // GET api/<controller>/11
        public IHttpActionResult Get(int id)
        {
            try
            {
                Usuario usuario = RepositorioUsuarios.ObtenerUsuario(id);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Usuario usuario)
        {
            try
            {
                RepositorioUsuarios.AgregarUsuario(usuario);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Usuario usuario)
        {
            try
            {
                RepositorioUsuarios.Modificar(id, usuario);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }*/

    }
}
