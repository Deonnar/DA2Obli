using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tresana.Data.Entities;

namespace Tresana.Web.Services
{
        public interface IPaymentService : IDisposable
        {
            Payment GetPaymentById(int taskId);
            IEnumerable<Payment> GetAllPayments();
            int CreatePayment(Payment payment);
            bool UpdatePayment(int paymentId, Payment payment);
            bool DeletePayment(int paymentId);
        
    }
}
