using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.Dominio.Entidades.Proveedores; 
//using TodoPagos.LogicaNegocio;
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public class RepositorioCamposFactura
    {
        public static void Agregar(int Id)
        {
            BdContexto contexto = BdContexto.GetInstance();
            CamposFactura campos = contexto.CamposFacturas.Include("CamposFacturas").ToList().Find(c => c.CamposFacturaId == Id);
            contexto.SaveChanges();
        }

        public static IEnumerable<CamposFactura> ObtenerCamposFacturas()
        {
           // agregarDatos();
            BdContexto contexto = BdContexto.GetInstance();
            var campos = (from u in contexto.CamposFacturas
                            select u);
            return campos;
        }

        public static void Agregar(CamposFactura unCampo)
        {
            BdContexto contexto = BdContexto.GetInstance();
            contexto.CamposFacturas.Add(unCampo);
            contexto.SaveChanges();
        }

        public static CamposFactura ObtenerCampo(int unId)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var facturas = (from u in contexto.CamposFacturas
                            where u.CamposFacturaId == unId                            
                            select u);
            return facturas.First();
        }

        private static void agregarDatos()
        {
            BdContexto contexto = BdContexto.GetInstance();

            Administrador admin = new Administrador();

            admin.Apellido = "Perez";
            admin.Direccion = "Rivera 13";
            admin.Nombre = "Juan";
            admin.NombreUsuario = "jperez";
  
            contexto.Administradores.Add(admin);
            contexto.SaveChanges();



            Administrador admin2 = new Administrador();

            admin2.Apellido = "Perez";
            admin2.Direccion = "Rivera 13";
            admin2.Nombre = "Juan";
            admin2.NombreUsuario = "jperez";

            contexto.Administradores.Add(admin2);
            contexto.SaveChanges();


            Cliente cliente = new Cliente();

             cliente.Email = "test@gmail.com";
             cliente.Direccion = "Rivera 123";
             cliente.Nombre = "Juan";
             cliente.Telefono = "093444474";
             Guid  guid = Guid.NewGuid();

             contexto.Clientes.Add(cliente);
             contexto.SaveChanges();
        
             Cliente cliente2 = new Cliente();

             cliente2.Email = "and123@gmail.com";
             cliente2.Direccion = "Durazno y ejido";
             cliente2.Nombre = "Martin";
             cliente2.Telefono = "099887776";
             contexto.Clientes.Add(cliente2);
             contexto.SaveChanges();

             //proveedores
             Proveedor p = new Proveedor();
             p.NombreProveedor = "IMM";
             p.Descripcion = "Intendencia";
             contexto.Proveedores.Add(p);
             contexto.SaveChanges();            
            

             Pago up = new Pago();
             up.ImporteFactura = 85;
             up.EstaPaga = true;
             up.FechaEmision = System.DateTime.Now;
             up.FechaVencimiento = System.DateTime.Today;
             up.PagoId = 1;
             up.Proveedor = p;
             up.Cliente = cliente;
             contexto.Pagos.Add(up);
             contexto.SaveChanges();

             Pago pago = new Pago();
             pago.ImporteFactura = 85;
             pago.EstaPaga = false;
             pago.FechaEmision = System.DateTime.Now;
             pago.FechaVencimiento = System.DateTime.Today;
             pago.PagoId = 1;
             pago.Proveedor = p;
             pago.Cliente = cliente;

             contexto.Pagos.Add(pago);
             contexto.SaveChanges();

        }

        public static void Modificar(int id, CamposFactura camposFacturas)
        {
            throw new NotImplementedException();
        }
    }
}
