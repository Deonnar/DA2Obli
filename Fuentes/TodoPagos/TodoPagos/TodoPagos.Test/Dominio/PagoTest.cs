using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoPagos.Dominio.Entidades.Pagos;

namespace TodoPagos.Test.Dominio
{
    [TestClass]
    public class PagoTest
    {
        [TestMethod]
        public void TestFechaEmisionPago()
        {
            Pago pago = new Pago();
            pago.FechaEmision = System.DateTime.Today;
            Assert.Equals(System.DateTime.Today, pago.FechaEmision);
        }

        [TestMethod]
        public void TestFechaVencimientoPago()
        {
            Pago pago = new Pago();
            pago.FechaVencimiento = System.DateTime.Today;
            Assert.Equals(System.DateTime.Today, pago.FechaVencimiento);
        }

        [TestMethod]
        public void TestImportaFacturaPago()
        {
            Pago pago = new Pago();
            pago.ImporteFactura = 900;
            Assert.Equals(900, pago.ImporteFactura);
        }
    }
}
