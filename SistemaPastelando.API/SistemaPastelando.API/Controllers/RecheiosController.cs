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
    public class RecheiosController : ControllerBase
    {
        private readonly IRecheioRepository _recheioRepository;

        public RecheiosController(IRecheioRepository recheioRepository)
        {
            _recheioRepository = recheioRepository;
        }

        // GET: api/Recheios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recheio>>> GetRecheios()
        {
            return await _recheioRepository.GetAll().ToListAsync();
        }

        // GET: api/Recheios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recheio>> GetRecheio(int id)
        {
            var recheio = await _recheioRepository.GetById(id);

            if (recheio == null)
            {
                return NotFound();
            }

            return recheio;
        }

        // PUT: api/Recheios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecheio(int id, Recheio recheio)
        {

            if (id != recheio.RecheioId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _recheioRepository.Update(recheio);
                return Ok(new
                {
                    message = $"{recheio.Nome} Atualizado com sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // POST: api/Recheios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Recheio>> PostRecheio(Recheio recheio)
        {
            if (ModelState.IsValid)
            {
                await _recheioRepository.Add(recheio);
                return Ok(new
                {
                    message = $"{recheio.Nome} Adicionado com Sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // DELETE: api/Recheios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecheio(int id)
        {
            var recheio = await _recheioRepository.GetById(id);
            if (recheio == null)
            {
                return NotFound();
            }

            await _recheioRepository.Delete(id);

            return Ok(new
            {
                message = $"{recheio.Nome} Excluido com Sucesso"
            });
        }

    }
}
