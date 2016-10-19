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

        public PagosController(){}     

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

        public IHttpActionResult Put(int id, [FromBody]Pago pago)
        {
            //no se deben modificar los pagos
            return null;
        }     
     
    }
}
