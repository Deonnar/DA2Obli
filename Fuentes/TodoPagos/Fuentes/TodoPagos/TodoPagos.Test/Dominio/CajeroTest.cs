using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoPagos.Dominio;
using TodoPagos.Dominio.Entidades;
using TodoPagos.Dominio.Entidades.Usuarios;

namespace TodoPagos.Test.Dominio
{
    [TestClass]
    public class CajeroTest
    {
        [TestMethod]
        public void TestPruebaDireccionCajero()
        {
            Cajero cajero = new Cajero();
            cajero.Direccion = "Canelones 140";
            Assert.AreEqual("Canelones 140", cajero.Direccion);
        }

        [TestMethod]
        public void TestPruebaNombreCajero()
        {
            Cajero cajero = new Cajero();
            cajero.Nombre = "Alan";
            Assert.AreEqual("Alan", cajero.Nombre);
        }

        [TestMethod]
        public void TestPruebaApellidoUsuarioCajero()
        {
            Cajero cajero = new Cajero();
            cajero.Apellido = "Perez";
            Assert.AreEqual("Perez", cajero.Apellido);
        }

        [TestMethod]
        public void TestPruebaNombreUsuarioCajero()
        {
            Cajero cajero = new Cajero();
            cajero.NombreUsuario = "b";

            Assert.AreEqual("b", cajero.NombreUsuario);
        }

        [TestMethod]
        public void TestPruebaContraseñaCajero()
        {
            Cajero cajero = new Cajero();
            cajero.Contrasenia = "b";
        }

        [TestMethod]
        public void TestPruebaGuidCajero()
        {
            Cajero cajero = new Cajero();
            Guid guid = Guid.NewGuid();
            cajero.Token = guid;
            Assert.IsNotNull(cajero.Token);                
        }
    }
}
