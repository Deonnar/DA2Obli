using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.LogicaRepositorio;
using TodoPagos.Dominio;



namespace TodoPagos.Test.Gestores
{
    [TestClass]
    public class GestionPagosTest
    {
        private static Pago pago = new Pago();
        public void SetUp()
        {
            BdContexto contexto = BdContexto.GetInstance();          

        }

        private Pago CrearPago()
        {
            Pago pago = new Pago();
            pago.FechaEmision = System.DateTime.Today;
            pago.FechaVencimiento = System.DateTime.Today.AddDays(3);
            return pago;
        }
    
          



        [TestMethod]
        public void NuevaPagoTest()
        {
            SetUp();
            Pago pago = CrearPago();
            RepositorioPagos.Agregar(pago);
            Assert.Equals(pago, RepositorioPagos.ObtenerPago(pago.PagoId));
        }

        [TestMethod]
        public void EliminarPagoTest()
        {
            SetUp();
            Pago pago = CrearPago();
            RepositorioPagos.Eliminar(pago);
            Assert.IsNull(RepositorioPagos.ObtenerPago(pago.PagoId));
        }


    }
}
