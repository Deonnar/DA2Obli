﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.LogicaRepositorio;

namespace TodoPagos.RestApi.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return RepositorioUsuarios.ObtenerUsuarios();
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            try
            {
            //    Usuario usuario = UsuarioFuncionalidades.Obtener(id);
             //   return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return null;
        }


        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Usuario usuario)
        {
            try
            {
           //     UsuarioFuncionalidades.Agregar(usuario);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Usuario usuario)
        {
            try
            {
           //     UsuarioFuncionalidades.Modificar(id, usuario);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            // No se implementa
        }
    }
}

