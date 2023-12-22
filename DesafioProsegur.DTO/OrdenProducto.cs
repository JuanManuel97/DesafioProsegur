using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProsegur.DTO
{
    public class OrdenProducto
    {
        [Column(Order = 1)]
        public int IdOrden { get; set; }

        [Column(Order = 2)]
        public int IdProducto { get; set; }
        public decimal CantidadProducto { get; set; }

        [ForeignKey("IdOrden")]
        public virtual Orden Orden { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }
    }
}
