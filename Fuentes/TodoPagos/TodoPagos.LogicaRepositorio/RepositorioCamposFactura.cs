using System;
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
    public class RepositorioCamposFactura
    {
        public static void Agregar(int Id)
        {
            BdContexto contexto = BdContexto.GetInstance();
            //  Usuario usuario = contexto.Usuarios.Include("Usuarios").ToList().Find(u => u.UsuarioId == IdUsuario);
            contexto.SaveChanges();
        }

        public static IEnumerable<CamposFactura> ObtenerCamposFacturas()
        {
            CamposFactura c = new CamposFactura();
            c.Descripcion = "UTE";
            Agregar(c);
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


        public static Usuario ValidacionLogIn(String mail, String clave)
        {
            BdContexto contexto = BdContexto.GetInstance();
            try
            {
                var usuario = (from u in contexto.Usuarios
                                   // where u.Email == mail && u.Clave == clave
                               select u);
                return usuario.First();
            }
            catch
            {
                return null;
            }
        }
    }
}
