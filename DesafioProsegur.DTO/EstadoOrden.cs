using System.ComponentModel.DataAnnotations;

namespace DesafioProsegur.Schema
{
    public class EstadoOrden
    {
        [Key]
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Orden> Ordenes { get; set; }
    }
}
