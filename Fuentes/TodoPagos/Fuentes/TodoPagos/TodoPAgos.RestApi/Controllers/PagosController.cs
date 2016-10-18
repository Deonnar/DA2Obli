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
    public class PagosController : ApiController
    {

        public PagosController()
        {
            //  repositorioUsuarios = new ServiciosUsuario();
        }
      

        // GET api/values
        [HttpGet]
        public IEnumerable<Pago> Get()
        {
            IEnumerable<Pago> listaUsuarios = RepositorioPagos.ObtenerPagos();

            return listaUsuarios;
        }

        // GET api/<controller>/11
        public IHttpActionResult Get(int id)
        {
            try
            {  
               Pago pago = RepositorioPagos.ObtenerPago(id);
               return Ok(pago);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }


       /* // POST api/<controller>
        public IHttpActionResult Post([FromBody]Pago p)
        {
            try
            {
                RepositorioPagos.Agregar(p);
                return Ok(p);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }*/

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]List<Pago> listaPagos)
        {
            try
            {
                foreach (Pago pago in listaPagos)
                {
                    RepositorioPagos.Agregar(pago);
                }
                return Ok(listaPagos);
             
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }




        /*
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
        }
        */
        // DELETE api/<controller>/11
        public void Delete(int id)
        {
            //repositorioUsuarios.BorrarUsuario(id);

        }
    }
}
