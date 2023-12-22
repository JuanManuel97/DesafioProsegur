using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProsegur.DTO
{
    public class ProductoMateriaPrima
    {
        [Column(Order = 1)]
        public int IdProducto { get; set; }

        [Column(Order = 2)]
        public int IdMateriaPrima { get; set; }

        public decimal CantidadPorUnidad { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }

        [ForeignKey("IdMateriaPrima")]
        public virtual MateriaPrima MateriaPrima { get; set; }
    }
}
