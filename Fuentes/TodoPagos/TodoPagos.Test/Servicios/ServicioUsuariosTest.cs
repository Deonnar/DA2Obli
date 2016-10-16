using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoPagos.Repositorio;
using TodoPagos.Dominio.Entidades.Usuarios;
using Moq;
using TodoPagos.Servicios;
using System.Collections.Generic;


namespace TodoPagos.Test.Servicios
{
    [TestClass]
    public class ServicioUsuariosTest
    {
        [TestMethod]
        public void ObtenerTodosLosUsuariosDelRepositorio()
        {
            //Arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork.Setup(un => un.RepositorioUsuario.ObtenerLista(null, null, ""));

            IServiciosUsuarios serviciosUsuarios  = new ServiciosUsuario(mockUnitOfWork.Object);

            //Act
            IEnumerable<Usuario> returnedUsers = serviciosUsuarios.ObtenerUsuarios();

            //Assert
            mockUnitOfWork.VerifyAll();
        }

        [TestMethod]
        public void ObtenerUsuarioPorId()
        {
            //Arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            //Esperamos que se llame al metodo Get del userRepository con un int
            mockUnitOfWork.Setup(un => un.RepositorioUsuario.Obtener(It.IsAny<int>()));

            IServiciosUsuarios serviciosUsuarios = new ServiciosUsuario(mockUnitOfWork.Object);

            //Act
            Usuario usuarioObtenido = serviciosUsuarios.ObtenerUsuario(5);

            //Assert
            mockUnitOfWork.VerifyAll();
        }





    }
}
