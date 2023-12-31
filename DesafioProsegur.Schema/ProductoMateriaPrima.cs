﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioProsegur.Schema
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
