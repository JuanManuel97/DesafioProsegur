﻿using DesafioProsegur.API.Models;
using DesafioProsegur.Infrastructure;
using DesafioProsegur.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioProsegur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenController : ControllerBase
    {
        private readonly AppDBContext _context;

        public OrdenController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Orden>> CrearOrden(OrdenModel orden)
        {
            var ordenCreada = new Orden
            {
                Descripcion = orden.Descripcion,
                IdEstado = orden.IdEstado
            };
            _context.Ordenes.Add(ordenCreada);
            await _context.SaveChangesAsync();

            return Ok(orden);
        }

        [HttpGet]
        public async Task<ActionResult<Orden>> ObtenerOrden(int idOrden)
        {
            return Ok(await _context.Ordenes.Where(o => o.IdOrden == idOrden).ToListAsync());
        }
    }
}
