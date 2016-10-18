using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.LogicaNegocio.Entidades.Pagos;
using TodoPagos.Repositorio;

namespace TodoPagos.Test.Gestores
{
    [TestClass]
    public class GestionPagosTest
    {
        private static Factura fac = new Factura();
        private void SetUp()
        {
            IRepositoryPagos persistencia = new RepositoryPagos();
        }
        
        private void CrearFactura()
        {
            fac.NumeroFactura = "2";
            fac.FechaVencimiento = System.DateTime.Today;
            fac.FechaEmision = System.DateTime.Today;
            fac.EstaPaga = false;
            fac.Monto = 1233;
            fac.EstaBorrado = false;
        }


        [TestMethod]
        public void NuevaFacturaTest()
        {
            SetUp();
            CrearFactura();
            persistencia.AddElement(fac);
            Factura facturaSeleccionada = persistencia.ObtenerFactura(fac.FacturaId);

            string numeroFactura = "2";
            Assert.AreEqual(numeroFactura, facturaSeleccionada.NumeroFactura);

            Dispose();
        }

        [TestMethod]
        public void BorrarFacturaTest()
        {
            SetUp();
            CrearFactura();
            persistencia.DeleteElement(fac);

            Factura facturaSeleccionada = persistencia.ObtenerFactura(fac.FacturaId);
        
            Assert.IsTrue(facturaSeleccionada.EstaBorrado);
            Dispose();
        }

        [TestMethod]
        public void ModificarFacturaTest()
        {
            SetUp();
            CrearFactura();
            persistencia.Borrar(fac);
            Factura facturaSeleccionada = persistencia.ObtenerFactura(fac.FacturaId);
            // string numeroFactura = "20";
            int numeroFactura = 2;
            Assert.IsTrue(numeroFactura, facturaSeleccionada.FacturaId);
            Dispose();
        }

        [TestMethod]
        public void ObtenerFactura()
        {
            SetUp();
            CrearFactura();
            persistencia.Borrar(fac);
            Factura facturaSeleccionada = persistencia.ObtenerFactura(fac.FacturaId);
            int numeroFactura = 2;
            Assert.IsTrue(fac, facturaSeleccionada);
            Dispose();
            
        }
    }
    
}
