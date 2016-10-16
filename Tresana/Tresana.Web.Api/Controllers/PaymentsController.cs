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

namespace Tresana.Web.Api.Controllers
{
    public class PaymentsController : ApiController
    {
        private readonly IPaymentService paymentService;


        public PaymentsController()
        {
            //    userService = new UserService();
          //  paymentService = new PaymentService();

        }

        public PaymentsController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        // GET: api/Users
        public IHttpActionResult GetPayments()
        {
            IEnumerable<Payment> payments = paymentService.GetAllPayments();
            return Ok(payments);
        }
        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPayment(int id, Payment payment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != payment.Id)
            {
                return BadRequest();
            }

            if (!paymentService.UpdatePayment(id, payment))
            {
                return NotFound();
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Payment
        [ResponseType(typeof(Payment))]
        public IHttpActionResult PostPayment(Payment payment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int id = paymentService.CreatePayment(payment);

            return CreatedAtRoute("DefaultApi", new { id = payment.Id }, payment);
        }

        // DELETE: api/Payment/5
        [ResponseType(typeof(Payment))]
        public IHttpActionResult DeletePayment(int id)
        {
            if (paymentService.DeletePayment(id))
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return NotFound();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                paymentService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}