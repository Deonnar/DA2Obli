using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.Dominio.Entidades.Proveedores;

using TodoPagos.LogicaRepositorio;

namespace TodoPagos.Test.Gestores
{
    [TestClass]
    public class GestionPagosTest
    {  
        
        private static Pago pago = new Pago();
        private static Proveedor proveedor = new Proveedor();

        private void SetUp()
        {
            RepositorioPagos persistencia = new RepositorioPagos();
            proveedor.NombreProveedor = "UTE";
            proveedor.Descripcion = "Energia Electrica";
        }

        private void CrearFactura()
        {
            pago.FechaVencimiento = System.DateTime.Today;
            pago.FechaEmision = System.DateTime.Today;
            pago.EstaPaga = false;
            pago.Proveedor = proveedor;
  
        }
       /* 
        [TestMethod]
        public void NuevaFacturaTest()
        {
            SetUp();
            CrearFactura();
  
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
    */}
    
}
