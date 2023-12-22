using DesafioProsegur.API.Models;
using DesafioProsegur.Infrastructure;
using DesafioProsegur.Schema;
using Microsoft.AspNetCore.Mvc;

namespace DesafioProsegur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDBContext _context;

        public UsuarioController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> CrearUsuario([FromBody] UsuarioModel usuario)
        {
            var usuarioCreado = new Usuario
            {
                Nombre = usuario.Nombre,
                IdRol = usuario.IdRol
            };
            _context.Usuarios.Add(usuarioCreado);
            await _context.SaveChangesAsync();

            return Ok(usuario);
        }

        [HttpGet]
        public async Task<ActionResult<Usuario>> ObtenerUsuario(int idUsuario)
        {
            return Ok(await _context.Usuarios.Where(u => u.IdUsuario == idUsuario).ToListAsync());
        }
    }
}
