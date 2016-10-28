using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoPagos.Dominio;
using TodoPagos.Dominio.Entidades;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.Dominio.Entidades.Proveedores;
namespace TodoPagos.Test.Dominio
{
    [TestClass]
    public class CamposFacturaTest
    {
        [TestMethod]
        public void TestCampoFacturaDescripcion()
        {
            CamposFactura campo = new CamposFactura();
            campo.Descripcion = "Detalles";
            Assert.Equals("Detalles", campo.Descripcion);
        }

        [TestMethod]
        public void TestCamposFacturaProveedor()
        {
            Proveedor p = new Proveedor();

            CamposFactura campo = new CamposFactura();
            campo.Proveedor = p;
            Assert.IsNotNull(campo.Proveedor);
        }
    }
}
