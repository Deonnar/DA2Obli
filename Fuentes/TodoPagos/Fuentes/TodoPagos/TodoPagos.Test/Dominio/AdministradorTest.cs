using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TodoPagos.Dominio;
using TodoPagos.Dominio.Entidades;
using TodoPagos.Dominio.Entidades.Usuarios;

namespace TodoPagos.Test.Dominio
{
    [TestClass]
    public class AdministradorTest
    {
        [TestMethod]
        public void TestPruebaDireccionAdministrador()
        {
            Administrador admin = new Administrador();
            admin.Direccion = "Canelones 140";
            Assert.AreEqual("Canelones 140", admin.Direccion);
        }

        [TestMethod]
        public void TestPruebaNombreAdministrador()
        {
            Administrador admin = new Administrador();
            admin.Nombre = "Alan";
            Assert.AreEqual("Alan", admin.Nombre);
        }

        [TestMethod]
        public void TestPruebaApellidoUsuarioAdministrador()
        {
            Administrador admin = new Administrador();
            admin.Apellido = "Perez";
            Assert.AreEqual("Perez", admin.Apellido);
        }

        [TestMethod]
        public void TestPruebaNombreUsuarioAdministrador()
        {
            Administrador admin = new Administrador();
            admin.NombreUsuario = "b";

            Assert.AreEqual("b", admin.NombreUsuario);
        }

        [TestMethod]
        public void TestPruebaContraseñaAdministrador()
        {
            Administrador admin = new Administrador();
            admin.Contrasenia = "b";
        }

        [TestMethod]
        public void TestPruebaGuidAdministrador()
        {
            Administrador admin = new Administrador();
            Guid guid = Guid.NewGuid();
            admin.Token = guid;
            Assert.IsNotNull(admin.Token);
        }

    }
}
