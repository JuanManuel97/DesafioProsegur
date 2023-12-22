using DesafioProsegur.API.Models;
using DesafioProsegur.Infrastructure;
using DesafioProsegur.Schema;
using Microsoft.AspNetCore.Mvc;

namespace DesafioProsegur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoMateriaPrimaController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ProductoMateriaPrimaController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<ProductoMateriaPrima>> CrearProductoMateriaPrima(ProductoMateriaPrimaModel productoMateriaPrima)
        {
            var productoMateriaPrimaCreado = new ProductoMateriaPrima
            {
                IdProducto = productoMateriaPrima.IdProducto,
                IdMateriaPrima = productoMateriaPrima.IdMateriaPrima,
                CantidadPorUnidad = productoMateriaPrima.CantidadPorUnidad
            };
            _context.ProductoMateriaPrimas.Add(productoMateriaPrimaCreado);
            await _context.SaveChangesAsync();

            return Ok(productoMateriaPrima);
        }
    }
}
