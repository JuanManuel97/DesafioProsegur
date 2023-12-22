using DesafioProsegur.API.Models;
using DesafioProsegur.Infrastructure;
using DesafioProsegur.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioProsegur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ProductoController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> CrearProducto(ProductoModel producto)
        {
            var productoCreado = new Producto
            {
                Descripcion = producto.Descripcion,
                PrecioVenta = producto.PrecioVenta
            };
            _context.Productos.Add(productoCreado);
            await _context.SaveChangesAsync();

            return Ok(producto);
        }

        [HttpGet]
        public async Task<ActionResult<Producto>> ObtenerProducto(int idProducto)
        {
            return Ok(await _context.Productos.Where(p => p.IdProducto == idProducto).ToListAsync());
        }
    }
}
