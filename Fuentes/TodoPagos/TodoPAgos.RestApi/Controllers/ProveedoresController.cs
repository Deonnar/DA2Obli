using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoPagos.Dominio.Entidades.Proveedores;
using TodoPagos.LogicaRepositorio;

namespace TodoPagos.RestApi.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
       /* // GET api/values
        [HttpGet]
        public IEnumerable<Proveedor> Get()
        {
            return RepositorioProveedores.ObtenerProveedores();
        }

        // GET api/<controller>/11
        public IHttpActionResult Get(int id)
        {
            try
            {
                Proveedor proveedor = RepositorioProveedores.ObtenerProveedor(id);
                return Ok(proveedor);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return null;
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Proveedor proveedor)
        {
            try
            {
                //  RepositorioUsuarios.Agregar(usuario);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Proveedor proveedor)
        {
            try
            {
                //     RepositorioUsuarios.Modificar(id, usuario);
                return Ok(proveedor);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<controller>/11
        public void Delete(int id)
        {
            // No se implementa
        }*/
    }
}
