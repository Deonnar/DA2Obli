using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Dominio.Entidades.Puntos;
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public class RepositorioPuntos
    {
     
        public static IEnumerable<Puntos> ObtenerPuntos()
        {
            BdContexto contexto = BdContexto.GetInstance();
            var puntos = (from p in contexto.Puntos
                            select p);
            return puntos;
        }

        public static void AgregarPunto(Puntos unPunto)
        {
            BdContexto contexto = BdContexto.GetInstance();

            contexto.Puntos.Add(unPunto);
            contexto.SaveChanges();
        }

        public static void Modificar(int id, Puntos p)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Puntos aModificar = contexto.Puntos.Single(x => x.PuntosId == id);
            
            aModificar.ValorPunto = p.ValorPunto;
            contexto.SaveChanges();
        }


    }
}
