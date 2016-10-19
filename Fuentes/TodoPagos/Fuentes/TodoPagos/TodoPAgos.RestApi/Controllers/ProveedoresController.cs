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
    public class ProveedoresController : ApiController
    {
        // GET api/values
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
            
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Proveedor proveedor)
        {
            try
            {
                RepositorioProveedores.AgregarProveedor(proveedor);
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
                RepositorioProveedores.Modificar(id, proveedor);
                return Ok(proveedor);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
       
    }
}
