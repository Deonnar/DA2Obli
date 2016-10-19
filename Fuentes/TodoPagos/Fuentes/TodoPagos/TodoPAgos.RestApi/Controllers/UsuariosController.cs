using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.LogicaRepositorio;

namespace TodoPagos.RestApi.Controllers
{
    public class UsuariosController : ApiController
    {
       // private readonly IServiciosUsuarios repositorioUsuarios;

        public UsuariosController(){
          //  repositorioUsuarios = new ServiciosUsuario();
        }
        
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

                /* if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.Id)
            {
                return BadRequest();
            }

            if(!userService.UpdateUser(id, user))
            {
                return NotFound();
            }
            return StatusCode(HttpStatusCode.NoContent);
                
                
                
                */
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<controller>/11
        public void Delete(int id)
        {
            //repositorioUsuarios.BorrarUsuario(id);
            
        }
    }
}

