using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.LogicaRepositorio;

namespace TodoPAgos.RestApi.Controllers
{
    public class CamposFacturasController : ApiController
    {
        public CamposFacturasController()
        {
            //  repositorioUsuarios = new ServiciosUsuario();
        }
      /*  public UsuariosController(IServiciosUsuarios u)
        {
            //  this.repositorioUsuarios = u;
        }*/

        // GET api/values
        [HttpGet]
        public IEnumerable<CamposFactura> Get()
        {
            IEnumerable<CamposFactura> facturas = RepositorioCamposFactura.ObtenerCamposFacturas();
            return facturas;
        }

        // GET api/<controller>/11
        public IHttpActionResult Get(int id)
        {
            try
            {
                CamposFactura usuario = RepositorioCamposFactura.ObtenerCampo(id);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // POST api/<controller>
       /* public IHttpActionResult Post([FromBody]Usuario usuario)
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
                // RepositorioUsuarios.Modificar(id, usuario);
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
                
                
                
                
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }*/

        // DELETE api/<controller>/11
        public void Delete(int id)
        {
            //repositorioUsuarios.BorrarUsuario(id);

        }
    }
}
