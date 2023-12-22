using System.ComponentModel.DataAnnotations;

namespace DesafioProsegur.Schema
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
