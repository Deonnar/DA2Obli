using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public class RepositorioClientes
    {
        public static void Agregar(int Id)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Cliente cliente = contexto.Clientes.Include("Clientes").ToList().Find(c => c.ClienteId == Id);
            contexto.SaveChanges();
        }

        public static IEnumerable<Cliente> ObtenerClientes()
        {
           
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Clientes
                            select u);
            return usuarios;
        }

        public static void Agregar(Cliente unCliente)
        {
            BdContexto contexto = BdContexto.GetInstance();
            contexto.Clientes.Add(unCliente);
            contexto.SaveChanges();
        }

        public static Cliente Obtener(int id)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Clientes
                            where u.ClienteId == id
                            select u);
            return usuarios.First();
        }      

        public static void Modificar(int id, Cliente cliente)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Cliente aModificar = contexto.Clientes.Single(u => u.ClienteId == id);
         
            aModificar.Nombre = cliente.Nombre;
            aModificar.Direccion = cliente.Direccion;
            aModificar.Email = cliente.Email;
            aModificar.Telefono = cliente.Telefono;
            contexto.SaveChanges();
        }
    }
}
