using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using TodoPagos.Dominio.Entidades.Proveedores;
using TodoPagos.LogicaRepositorio;
using TodoPagos.Seguridad;
using TodoPagos.Dominio.Entidades.Log;

namespace TodoPAgos.RestApi.Controllers
{
    public class LogsController : ApiController
    {
        public LogsController() { }

        // GET api/values
        [HttpGet]
        public IEnumerable<Historial> Get()
        {
            ValidarAcceso.TieneAccesso(Request);
            IEnumerable<Historial> listaHistorial = RepositorioLogs.ObtenerHistorial();
            return listaHistorial;
        }

        public IHttpActionResult Post([FromBody]Historial nuevoLog)
        {
            try
            {
                RepositorioLogs.Agregar(nuevoLog);
                
                return Ok(nuevoLog);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
