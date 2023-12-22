using DesafioProsegur.API.Models;
using DesafioProsegur.Infrastructure;
using DesafioProsegur.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioProsegur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        private readonly AppDBContext _context;

        public CiudadController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Ciudad>> ObtenerCiudad(int idCiudad)
        {
            return Ok(await _context.Ciudades.Where(c => c.IdCiudad == idCiudad).ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Ciudad>> CrearCiudad(CiudadModel ciudad)
        {
            var ciudadCreada = new Ciudad
            {
                Nombre = ciudad.Nombre,
                PorcentajeImpuesto = ciudad.PorcentajeImpuesto
            };
            _context.Ciudades.Add(ciudadCreada);
            await _context.SaveChangesAsync();

            return Ok(ciudad);
        }
    }
}
