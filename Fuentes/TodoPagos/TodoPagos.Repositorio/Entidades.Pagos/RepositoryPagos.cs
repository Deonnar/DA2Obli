using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Pagos;

namespace TodoPagos.Repositorio.Entidades.Pagos
{
    public class RepositoryPagos
    {
        private Repository<Factura> repositorio;

        public RepositoryPagos()
        {
        }

        public void AgregarFactura(Factura factura)
        {
            repositorio.Agregar(factura);
        }

        public Factura ObtenerFactura(Factura factura)
        {
            return repositorio.Obtener(factura);
        }

        void BorrarFactura(Factura factura)
        {
            repositorio.Borrar(factura);
        }

        void ActualizarFactura(Factura factura)
        {
            repositorio.Actualizar(factura);
        }
    }
}
