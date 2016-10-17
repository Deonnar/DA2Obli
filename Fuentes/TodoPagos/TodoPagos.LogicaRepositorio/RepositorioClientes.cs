﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.LogicaNegocio;
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public class RepositorioClientes
    {
        public static void Agregar(int Id)
        {
            BdContexto contexto = BdContexto.GetInstance();
            //  Usuario usuario = contexto.Usuarios.Include("Usuarios").ToList().Find(u => u.UsuarioId == IdUsuario);
            contexto.SaveChanges();
        }

        public static IEnumerable<Cliente> ObtenerClientes()
        {
            Cliente cliente = new Cliente();
            cliente.Apellido = "Perez";
            cliente.Email = "test@gmail.com";
            cliente.Direccion = "Rivera 123";
            cliente.Nombre = "Juan";
            cliente.Telefono = "474";
  
            Agregar(cliente);
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
    }
}
