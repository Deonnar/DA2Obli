using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Puntos;
using TodoPagos.LogicaRepositorio;
using TodoPagos.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TodoPagos.Test.Gestores
{
    [TestClass]
    public class PuntosTest
    {
        private static Puntos punto = new Puntos();
        public void SetUp()
        {
            BdContexto contexto = BdContexto.GetInstance();
           
        }

        private Puntos CrearPuntos()
        {
            punto.ValorPunto = 10;
            return punto;
        }


    }
}
