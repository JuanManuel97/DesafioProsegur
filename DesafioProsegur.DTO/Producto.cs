﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProsegur.DTO
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }

        public ICollection<OrdenProducto> OrdenProductos { get; set; }

        public ICollection<ProductoMateriaPrima> ProductoMateriaPrimas { get; set; }
    }
}