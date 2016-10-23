using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoPagos.Repositorio;
using TodoPagos.Dominio.Entidades.Usuarios;
using System.Collections.Generic;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.Dominio.Entidades.Proveedores;
using TodoPagos.Dominio;

namespace TodoPagos.Test.Servicios
{
    [TestClass]
    public class ServicioUsuariosTest
    {
   /*     [TestMethod]
        public void ObtenerTodosLosUsuariosDelRepositorio()
        {
            //Arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork.Setup(un => un.RepositorioUsuario.ObtenerLista(null, null, ""));

           // IServiciosUsuarios serviciosUsuarios  = new ServiciosUsuario(mockUnitOfWork.Object);

            //Act
         //   IEnumerable<Usuario> returnedUsers = serviciosUsuarios.ObtenerUsuarios();

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

           // IServiciosUsuarios serviciosUsuarios = new ServiciosUsuario(mockUnitOfWork.Object);

            //Act
       //     Usuario usuarioObtenido = serviciosUsuarios.ObtenerUsuario(5);

            //Assert
            mockUnitOfWork.VerifyAll();
        }


        public void Datos()
        {
            BdContexto contexto = BdContexto.GetInstance();
              Pago up = new Pago();
            up.ImporteFactura = 30;
            up.FechaEmision = System.DateTime.Today;
            up.FechaVencimiento = System.DateTime.Today;
            up.PagoId = 1;         
            contexto.Pagos.Add(up);
        }
    */}
}
