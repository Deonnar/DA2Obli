using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoPagos.Dominio.Entidades.Proveedores;

namespace TodoPagos.Test.Dominio
{

    [TestClass]
    public class ProveedoresBloqueadosTest
    {
        public ProveedoresBloqueadosTest()
        {
         
        }

     
        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        { //cual es la relacion entre poveedored y puntos ¿¿
            Proveedor prov = new Proveedor();
            prov.NombreProveedor = "Proveedor1";
            ProveedoresBloqueados p = new ProveedoresBloqueados();
            p.Proveedor = prov;
            p.MotivoBloqueo = "Demora en pagar";
        }
    }
}
