using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesafioProsegur.Schema
{
    public class Orden
    {
        [Key]
        public int IdOrden { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }

        public virtual EstadoOrden Estado { get; set; }

        public ICollection<OrdenProducto> OrdenProductos { get; set; }
    }
}
