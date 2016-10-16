using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using TodoPagos.Dominio.Entidades.Usuarios;
=======
using TodoPagos.LogicaNegocio.Entidades.Usuarios;
>>>>>>> feature/dominio
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
