using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProsegur.DTO
{
    public class Ciudad
    {
        [Key]
        public int IdCiudad { get; set; }
        public string Nombre { get; set; }
        public decimal PorcentajeImpuesto { get; set; } = 0;
    }
}
