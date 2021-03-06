﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.LogicaNegocio.Entidades.Usuarios;
using TodoPagos.Repositorio;

namespace TodoPagos.Test.Gestores
{
    [TestClass]
    public class GestionUsuariosTest
    {
        private static Cajero cajero = new Cajero();
        private void SetUp()
        {
            IRepositoryUsuario persistencia = new RepositoryUsuario();
        }

        private void CrearUsuario()
        {
           // NumeroIdentificacion = "1";
            cajero.Nombre = "Alan";
            cajero.Apellido = "Rodriguez";
            cajero.Cedula = "222222-2";
            cajero.Direccion = "Rivera 123";
            cajero.EstaBorrado = false;
        }


        [TestMethod]
        public void NuevaCajeroTest()
        {
            SetUp();
            CrearUsuario();
            persistencia.Agregar(cajero);
            Cajero cajeroSeleccionado = persistencia.ObtenerCajero(cajero.UsuarioId);

            string nombre = "Alan";
            Assert.AreEqual(nombre, cajeroSeleccionado.nombre);

            Dispose();
        }

        [TestMethod]
        public void BorrarCajeroTest()
        {
            SetUp();
            CrearFactura();
            persistencia.Borrar(cajero);

            Factura cajeroSeleccionado = persistencia.ObtenerFactura(cajero.UsuarioId);
          
            Assert.IsTrue(cajeroSeleccionado.EstaBorrado);
            Dispose();
        }

        [TestMethod]
        public void ModificarCajeroTest()
        {
            SetUp();
            CrearFactura();

            Cajero cajeroSeleccionado = persistencia.ObtenerCajero(cajero.UsuarioId);

            cajeroSeleccionado.Nombre = "John";
            persistencia.Modificar(cajeroSeleccionado);
            
            Assert.AreEqual("John", cajeroSeleccionado.Nombre );
            Dispose();
        }

        [TestMethod]
        public void ObtenerCajero()
        {
            SetUp();
            CrearCajero();
            Cajero cajeroSeleccionado = persistencia.ObtenerCajero(cajero.UsuarioId);

            Assert.AreEqual(cajero, cajeroSeleccionado);
            Dispose();

        }
    }

        /*
        [TestMethod]
        public void GetAllCajeros()
        {
            int cantidadCajeros = 2;

            var mockSet = new Mock<DbSet<Cajero>>();
            var cajeros = CreateFakeCajeros(cantidadCajeros).AsQueryable();

            mockSet.As<IQueryable<Cajero>>().Setup(c => c.Provider).Returns(cajeros.Provider);
            mockSet.As<IQueryable<Cajero>>().Setup(c => c.Expression).Returns(cajeros.Expression);
            mockSet.As<IQueryable<Cajero>>().Setup(c => c.ElementType).Returns(cajeros.ElementType);
            mockSet.As<IQueryable<Cajero>>().Setup(c => c.GetEnumerator).Returns(cajeros.GetEnumerator());

            var mockContext = new Mock<Context>();
            mockContext.Setup(m => m.Cajeros).Return(mockSet.Object);

        }
        */
    }
}
