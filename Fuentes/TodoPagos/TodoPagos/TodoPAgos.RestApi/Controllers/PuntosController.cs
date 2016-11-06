using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoPagos.Dominio.Entidades.Puntos;
using TodoPagos.LogicaRepositorio;
using TodoPagos.Seguridad;

namespace TodoPAgos.RestApi.Controllers
{
    public class PuntosController : ApiController
    {
        public PuntosController() { }

        // GET api/values
        [HttpGet]
        public IEnumerable<Puntos> Get()
        {
            ValidarAcceso.TieneAccesso(Request);

            IEnumerable<Puntos> listaPuntos = RepositorioPuntos.ObtenerPuntos();
            return listaPuntos;
        }

        // GET api/<controller>/11
        public IHttpActionResult Get(int id)
        {
            ValidarAcceso.TieneAccesso(Request);

            try
            {
             //   Puntos puntos = RepositorioPuntos.ObtenerPuntos(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Puntos p)
        {
            ValidarAcceso.TieneAccesso(Request);

            try
            {
                RepositorioPuntos.AgregarPunto(p);
                return Ok(p);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Puntos puntos)
        {
            ValidarAcceso.TieneAccesso(Request);
            try
            {
                RepositorioPuntos.Modificar(id, puntos);
                return Ok(puntos);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
