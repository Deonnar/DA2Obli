using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoPagos.Test.Pagos;
{
    public class GestionFacturaTest
    {
        private static Factura factura= new Factura();
        private void SetUp()
        {
            IRepositoryFactura persistencia = new RepositoryFactura();
        }

        private void CrearFactura()
        {
            // NumeroIdentificacion = "1";
            
            factura.
            factura.Cedula = "222222-2";
            factura.Direccion = "Rivera 123";
        }


        [TestMethod]
        public void NuevaFacturaTest()
        {
            SetUp();
            CrearFactura();
            persistencia.Agregar(factura);
            Factura facturaSeleccionado = persistencia.ObtenerFactura(factura.FacturaId);

            string nombre = "Alan";
            Assert.AreEqual(nombre, facturaSeleccionado.nombre);

            Dispose();
        }

        [TestMethod]
        public void BorrarFacturaTest()
        {
            SetUp();
            CrearFactura();
            persistencia.Borrar(factura);

            Factura facturaSeleccionada = persistencia.ObtenerFactura(factura.FacturaId);

            Assert.IsTrue(facturaSeleccionada.EstaBorrada);
            Dispose();
        }

        [TestMethod]
        public void ModificarFacturaTest()
        {
            SetUp();
            CrearFactura();

            Factura facturaSeleccionado = persistencia.ObtenerFactura(factura.FacturaId);

            facturaSeleccionado.Nombre = "John";
            persistencia.Modificar(facturaSeleccionado);

            Assert.AreEqual("John", facturaSeleccionado.Nombre);
            Dispose();
        }

        [TestMethod]
        public void ObtenerFactura()
        {
            SetUp();
            CrearFactura();
            Factura facturaSeleccionado = persistencia.ObtenerFactura(factura.FacturaId);

            Assert.IsTrue(factura, facturaSeleccionado);
            Dispose();

        }
    }







}
}
