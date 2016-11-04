using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Dominio.Entidades.Log;
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public class RepositorioLogs
    {
        public static IEnumerable<Historial> ObtenerHistorial()
        {
            BdContexto contexto = BdContexto.GetInstance();
            var historial = (from u in contexto.Log
                            select u);
            return historial;
        }

        public static void Agregar(Historial unHistorial)
        {
            BdContexto contexto = BdContexto.GetInstance();

            contexto.Log.Add(unHistorial);
            contexto.SaveChanges();
        }
    }
}
