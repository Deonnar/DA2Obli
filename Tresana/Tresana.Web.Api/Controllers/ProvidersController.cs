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
using Tresana.Web.Services.Interfaces;

namespace Tresana.Web.Api.Controllers
{
    public class ProvidersController : ApiController
    {
        private readonly IProviderService providerService;

        //public UsersController()
        //{
        //    userService = new UserService();
        //}

        public ProvidersController(IProviderService userService)
        {
            this.providerService = userService;
        }

        // GET: api/Users
        public IHttpActionResult GetUsers()
        {
            IEnumerable<Provider> providers = providerService.GetAllProviders();
            return Ok(providers);
        }
        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(int id, Provider user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.ProviderId)
            {
                return BadRequest();
            }

            if (!providerService.UpdateProvider(id, user))
            {
                return NotFound();
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Users
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(Provider user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int id = providerService.CreateProvider(user);

            return CreatedAtRoute("DefaultApi", new { id = user.ProviderId }, user);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(User))]
        public IHttpActionResult DeleteUser(int id)
        {
            if (providerService.DeleteProvider(id))
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return NotFound();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //this.providerService
            }
            base.Dispose(disposing);
        }
    }
}