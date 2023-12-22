using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProsegur.DTO
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
