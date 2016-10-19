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
        {}
     
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
        public IHttpActionResult Post([FromBody]CamposFactura camposFactura)
        {
            try
            {
                RepositorioCamposFactura.Agregar(camposFactura);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        // PUT api/<controller>/5 
        public IHttpActionResult Put(int id, [FromBody]CamposFactura camposFacturas)
        {
            try
            {
                RepositorioCamposFactura.Modificar(id, camposFacturas);
                return Ok(camposFacturas);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }        
    }
}
