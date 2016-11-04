using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoPagos.Dominio.Entidades.Proveedores;
using TodoPagos.LogicaRepositorio;
using TodoPagos.Seguridad;
using TodoPagos.Dominio.Entidades.Pagos;

namespace TodoPAgos.RestApi.Controllers
{
    public class ProveedoresBloqueadosController : ApiController
    {
        public ProveedoresBloqueadosController() { }

        // GET api/values
        [HttpGet]
        public IEnumerable<ProveedoresBloqueados> Get()
        {
            ValidarAcceso.TieneAccesso(Request);

            IEnumerable<ProveedoresBloqueados> listaProveedores = RepositorioProveedoresBloqueados.ObtenerProveedores();
            return listaProveedores;
        }

        // GET api/<controller>/11
        public IHttpActionResult Get(int id)
        {
            ValidarAcceso.TieneAccesso(Request);

            try
            {
                ProveedoresBloqueados prov = RepositorioProveedoresBloqueados.ObtenerProveedor(id);
                return Ok(prov);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]ProveedoresBloqueados c)
        {
            ValidarAcceso.TieneAccesso(Request);

            try
            {
                RepositorioProveedoresBloqueados.AgregarProveedor(c);
                return Ok(c);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]ProveedoresBloqueados proveedor)
        {
            ValidarAcceso.TieneAccesso(Request);
            try
            {
                //RepositorioProveedoresBloqueados.M(id, Pro);
                return Ok(proveedor);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
