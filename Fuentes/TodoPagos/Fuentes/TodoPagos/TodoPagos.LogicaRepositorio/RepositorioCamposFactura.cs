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
            agregarDatos();
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

            Cliente cliente = new Cliente();
         
            cliente.Email = "test@gmail.com";
            cliente.Direccion = "Rivera 123";
            cliente.Nombre = "Juan";
            cliente.Telefono = "474";
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();

            Proveedor p = new Proveedor();
            p.NombreProveedor = "UTE";
                contexto.Proveedores.Add(p);
                contexto.SaveChanges();
                CamposFactura campoFactura = new CamposFactura();
                campoFactura.Descripcion = "Watts";
                campoFactura.Proveedor = p;

                contexto.CamposFacturas.Add(campoFactura);
                contexto.SaveChanges();

                Pago up = new Pago();
                up.ImporteFactura = 85;
                up.EstaPaga = true;
                up.FechaEmision = System.DateTime.Today;
                up.FechaVencimiento = System.DateTime.Today;
                up.PagoId = 1;
                up.Proveedor = p;
                up.Cliente = cliente;
                contexto.Pagos.Add(up);
                contexto.SaveChanges();        

        }

        public static void Modificar(int id, CamposFactura camposFacturas)
        {
            throw new NotImplementedException();
        }
    }
}
