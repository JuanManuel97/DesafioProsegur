using DesafioProsegur.API.Models;
using DesafioProsegur.Infrastructure;
using DesafioProsegur.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioProsegur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly AppDBContext _context;

        public RolController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Rol>> CrearRol(RolModel rol)
        {
            var rolCreado = new Rol
            {
                Descripcion = rol.Descripcion
            };
            _context.Roles.Add(rolCreado);
            await _context.SaveChangesAsync();

            return Ok(rol);
        }

        [HttpGet]
        public async Task<ActionResult<Rol>> ObtenerRol(int idRol)
        {
            return Ok(await _context.Roles.Where(r => r.IdRol == idRol).ToListAsync());
        }
    }
}
