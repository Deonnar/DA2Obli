using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.LogicaRepositorio;
using System.Data.Entity;
using System.Web;
using System.Web.Http;
using TodoPagos.Dominio.Entidades.Usuarios;

namespace TodoPAgos.RestApi.Controllers
{
    public class ClientesController : ApiController
    {
        public ClientesController() {  }

        // GET api/values
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            IEnumerable<Cliente> listaClientes = RepositorioClientes.ObtenerClientes();
            return listaClientes;
        }

        // GET api/<controller>/11
        public IHttpActionResult Get(int id)
        {
            try
            {
                Cliente cliente = RepositorioClientes.Obtener(id);
                return Ok(cliente);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Cliente c)
        {
            try
            {
                RepositorioClientes.Agregar(c);
                return Ok(c);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
     
        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Cliente cliente)
        {
            try
            {
                RepositorioClientes.Modificar(id, cliente);
                return Ok(cliente);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        
    }
}
