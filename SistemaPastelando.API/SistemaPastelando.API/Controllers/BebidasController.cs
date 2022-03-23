using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaPastelando.BLL.Models;
using SistemaPastelando.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPastelando.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BebidasController : ControllerBase
    {
        private readonly IBebidaRepository _bebidaRepository;

        public BebidasController(IBebidaRepository bebidaRepository)
        {
            _bebidaRepository = bebidaRepository;
        }

        // GET: api/Bebidas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bebida>>> GetBebidas()
        {
            return await _bebidaRepository.GetAll().ToListAsync();
        }

        // GET: api/Bebidas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bebida>> GetBebida(int id)
        {
            var bebida = await _bebidaRepository.GetById(id);

            if (bebida == null)
            {
                return NotFound();
            }

            return bebida;
        }

        // PUT: api/Bebidas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBebida(int id, Bebida bebida)
        {

            if (id != bebida.BebidaId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _bebidaRepository.Update(bebida);
                return Ok(new
                {
                    message = $"{bebida.Nome} Atualizado com sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // POST: api/Bebidas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bebida>> PostBebida(Bebida bebida)
        {
            if (ModelState.IsValid)
            {
                await _bebidaRepository.Add(bebida);
                return Ok(new
                {
                    message = $"{bebida.Nome} Adicionado com Sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // DELETE: api/Bebidas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBebida(int id)
        {
            var bebida = await _bebidaRepository.GetById(id);
            if (bebida == null)
            {
                return NotFound();
            }

            await _bebidaRepository.Delete(id);

            return Ok(new
            {
                message = $"{bebida.Nome} Excluido com Sucesso"
            });
        }

    }
}
