using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using TodoPagos.RestApi.Models;
using TodoPagos.RestApi.Providers;
using TodoPagos.RestApi.Results;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.LogicaRepositorio;

namespace TodoPagos.RestApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/Facturas")]
    public class AccountController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Factura> Get()
        {
            return RepositorioFacturas.ObtenerFacturas();
        }

        // GET api/<controller>/11
        public IHttpActionResult Get(int id)
        {
            try
            {
                Factura factura = RepositorioFacturas.ObtenerFactura(id);
                return Ok(factura);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Factura factura)
        {
            try
            {
                RepositorioFacturas.AgregarFactura(factura);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Factura factura)
        {
            try
            {
                //RepositorioFacturas.Modificar(id, factura);
                return Ok(factura);
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
        }
    }
}
