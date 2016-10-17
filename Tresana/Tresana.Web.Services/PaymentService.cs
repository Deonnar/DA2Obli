using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tresana.Data.Entities;
using Tresana.Data.Repository;

namespace Tresana.Web.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork unitOfWork = new UnitOfWork();

        public PaymentService(){}

        //  public PaymentService(IUnitOfWork unitOfWork)
        // {
        //  this.unitOfWork = unitOfWork;
        // }

        public int CreatePayment(Payment payment)
        {
            unitOfWork.PaymentRepository.Insert(payment);
            unitOfWork.Save();
            return payment.Id;
        }

        public bool DeletePayment(int userId)
        {
            if (ExistsPayment(userId))
            {
                unitOfWork.PaymentRepository.Delete(userId);
                unitOfWork.Save();
                return true;
            }
            return false;
        }

        public IEnumerable<Payment> GetAllPayments()
        {
            return unitOfWork.PaymentRepository.Get(null, null, "");
        }

        public Payment GetPaymentById(int userId)
        {
            Payment payment = unitOfWork.PaymentRepository.GetByID(userId);
            return payment;
        }

        public bool UpdatePayment(int userId, Payment payment)
        {
            if (ExistsPayment(userId))
            {
                Payment paymentEntity = unitOfWork.PaymentRepository.GetByID(userId);
                paymentEntity.Amount = payment.Amount;
                paymentEntity.DueDate = payment.DueDate;
                paymentEntity.EmisionDate = payment.EmisionDate;
                paymentEntity.IsPaid = payment.IsPaid;
                unitOfWork.PaymentRepository.Update(paymentEntity);
                unitOfWork.Save();
                return true;
            }
            return false;
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }

        private bool ExistsPayment(int userId)
        {
            Payment payment = unitOfWork.PaymentRepository.GetByID(userId);
            return payment != null;
        }
    }
}
