using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesafioProsegur.DTO
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }

        [ForeignKey("Rol")]
        public int IdRol { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
