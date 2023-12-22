using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProsegur.DTO
{
    public class EstadoOrden
    {
        [Key]
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Orden> Ordenes { get; set; }
    }
}
