using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Repositorio;

namespace TodoPagos.Repositorio.Entidades.Usuario
{
    interface IRepositoryCajeros
    {
        void AgregarCajero(Cajero cajero);

        Cajero ObtenerCajero(Cajero cajero);

        void BorrarCajero(Cajero cajero);

        void ActualizarCajero(Cajero cajero);
    }
}
