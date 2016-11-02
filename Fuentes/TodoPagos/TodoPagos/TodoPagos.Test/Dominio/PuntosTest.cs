using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Pagos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoPagos.Dominio.Entidades.Proveedores;
using TodoPagos.Dominio.Entidades.Puntos;


namespace TodoPagos.Test.Dominio
{
    [TestClass]
    public class PuntosTest
    {
        [TestMethod]
        public void TestCrearPuntos()
        {
            Puntos puntos = new Puntos();
            puntos.ValorPunto = 3;
            Assert.Equals(100, puntos.ValorPunto);
        }

        [TestMethod]
        public void TestPuntos()
        {
            Proveedor p = new Proveedor();
            Puntos puntos = new Puntos();
            Assert.Equals(100, puntos.ValorPunto);
        }

    }
}
