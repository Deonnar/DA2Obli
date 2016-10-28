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
    public class CajerosController : ApiController
    {
        public CajerosController() { }

        // GET api/values
        [HttpGet]
        public IEnumerable<Cajero> Get()
        {
            IEnumerable<Cajero> listaCajeros = RepositorioCajeros.ObtenerCajeros();
            return listaCajeros;
        }

        // GET api/<controller>/11
        public IHttpActionResult Get(int id)
        {
            try
            {
                Cajero usuario = RepositorioCajeros.ObtenerCajero(id);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Cajero usuario)
        {
            try
            {
                RepositorioCajeros.AgregarCajero(usuario);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Cajero usuario)
        {
            try
            {
                RepositorioCajeros.Modificar(id, usuario);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
