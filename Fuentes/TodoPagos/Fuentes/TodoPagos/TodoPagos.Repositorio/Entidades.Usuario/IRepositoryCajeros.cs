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
        void AgregarCajero(Administrador cajero);

        Administrador ObtenerCajero(Administrador cajero);

        void BorrarCajero(Administrador cajero);

        void ActualizarCajero(Administrador cajero);
    }
}
