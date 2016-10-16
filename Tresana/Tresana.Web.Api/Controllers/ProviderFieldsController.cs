using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tresana.Data.Entities;
using Tresana.Web.Services;
using Tresana.Web.Services.Implementations;

namespace Tresana.Web.Api.Controllers
{
    public class ProviderFieldsController : ApiController
    {
        private readonly IProviderFieldService providerService;

        //public UsersController()
        //{
        //    userService = new UserService();
        //}

        public ProviderFieldsController(IProviderFieldService service)
        {
            this.providerService = service;
        }

        // GET: api/Users
        public IHttpActionResult GetUsers()
        {
            IEnumerable<ProviderField> fields = providerService.GetAllProviderFields();
            return Ok(fields);
        }
        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(int id, ProviderField field)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != field.ProviderFieldId)
            {
                return BadRequest();
            }

            if (!providerService.UpdateProviderField(id, field))
            {
                return NotFound();
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Users
        [ResponseType(typeof(ProviderField))]
        public IHttpActionResult PostUser(ProviderField field)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int id = this.providerService.CreateProviderField(field);

            return CreatedAtRoute("DefaultApi", new { id = field.ProviderFieldId }, field);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(ProviderField))]
        public IHttpActionResult DeleteUser(int id)
        {
            if (providerService.DeleteProviderField(id))
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return NotFound();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //providerService.();
            }
            base.Dispose(disposing);
        }
    }
}