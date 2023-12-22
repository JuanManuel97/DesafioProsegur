using DesafioProsegur.API.Models;
using DesafioProsegur.Infrastructure;
using DesafioProsegur.Schema;
using Microsoft.AspNetCore.Mvc;

namespace DesafioProsegur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenProductoController : ControllerBase
    {
        private readonly AppDBContext _context;

        public OrdenProductoController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<OrdenProducto>> CrearUsuario(OrdenProductoModel ordenProducto)
        {
            var ordenProductoCreado = new OrdenProducto
            {
                IdOrden = ordenProducto.IdOrden,
                IdProducto = ordenProducto.IdProducto,
                CantidadProducto = ordenProducto.CantidadProducto
            };
            _context.OrdenProductos.Add(ordenProductoCreado);
            await _context.SaveChangesAsync();

            return Ok(ordenProducto);
        }
    }
}
