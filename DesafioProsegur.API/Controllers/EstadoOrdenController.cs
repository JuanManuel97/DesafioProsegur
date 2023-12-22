using DesafioProsegur.API.Models;
using DesafioProsegur.Infrastructure;
using DesafioProsegur.Schema;
using Microsoft.AspNetCore.Mvc;

namespace DesafioProsegur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoOrdenController : ControllerBase
    {
        private readonly AppDBContext _context;

        public EstadoOrdenController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<EstadoOrden>> CrearEstadoOrden(EstadoOrdenModel estadoOrden)
        {
            var estadoOrdenCreado = new EstadoOrden
            {
                Descripcion = estadoOrden.Descripcion
            };
            _context.EstadoOrdenes.Add(estadoOrdenCreado);
            await _context.SaveChangesAsync();

            return Ok(estadoOrden);
        }
    }
}
