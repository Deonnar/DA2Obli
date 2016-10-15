using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.LogicaNegocio.Entidades.Pagos;

namespace TodoPagos.Repositorio.Entidades.Pagos
{
    public interface IRepositoryPagos
    {
        void AgregarFactura(Factura factura);

        Factura ObtenerFactura(Factura factura);

        void BorrarFactura(Factura factura);

        void ActualizarFactura(Factura factura);
    }
}
