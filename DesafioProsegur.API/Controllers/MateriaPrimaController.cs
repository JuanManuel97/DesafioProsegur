using DesafioProsegur.API.Models;
using DesafioProsegur.Infrastructure;
using DesafioProsegur.Schema;
using Microsoft.AspNetCore.Mvc;

namespace DesafioProsegur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaPrimaController : ControllerBase
    {
        private readonly AppDBContext _context;

        public MateriaPrimaController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<MateriaPrima>> CrearMateriaPrima(MateriaPrimaModel materiaPrima)
        {
            var materiaPrimaCreada = new MateriaPrima
            {
                Descripcion = materiaPrima.Descripcion,
                Cantidad = materiaPrima.Cantidad,
                DescripcionCantidad = materiaPrima.DescripcionCantidad,
                Precio = materiaPrima.Precio
            };
            _context.MateriaPrimas.Add(materiaPrimaCreada);
            await _context.SaveChangesAsync();

            return Ok(materiaPrima);
        }

        [HttpGet]
        public async Task<ActionResult<Rol>> ObtenerMateriaPrima(int idMateriaprima)
        {
            return Ok(await _context.MateriaPrimas.Where(mp => mp.IdMateriaPrima == idMateriaprima).ToListAsync());
        }
    }
}
