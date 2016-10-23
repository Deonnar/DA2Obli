using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TodoPagos.Dominio.Entidades.Usuarios
{
    [Table("Usuarios")]
    public class Usuario
    {
        public Usuario() { }
        [Key]
        [Column("ID")]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; } 
        public string Direccion { get; set; }
        public string Contrasenia { get; set; }
        public string NombreUsuario { get; set; }
        public Boolean Autorizado{ get; set; }
        public Guid Token { get; set; }
        
    }
}
