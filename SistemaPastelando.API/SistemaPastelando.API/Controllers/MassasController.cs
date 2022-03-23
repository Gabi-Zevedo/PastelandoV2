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
    public class MassasController : ControllerBase
    {
        private readonly IMassaRepository _massaRepository;

        public MassasController(IMassaRepository massaRepository)
        {
            _massaRepository = massaRepository;
        }

        // GET: api/Massas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Massa>>> GetMassas()
        {
            return await _massaRepository.GetAll().ToListAsync();
        }

        // GET: api/Massas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Massa>> GetMassa(int id)
        {
            var massa = await _massaRepository.GetById(id);

            if (massa == null)
            {
                return NotFound();
            }

            return massa;
        }

        // PUT: api/Massas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMassa(int id, Massa massa)
        {

            if (id != massa.MassaId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _massaRepository.Update(massa);
                return Ok(new
                {
                    message = $"Massa '{massa.Nome}' Atualizado com sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // POST: api/Massas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Massa>> PostMassa(Massa massa)
        {
            if (ModelState.IsValid)
            {
                await _massaRepository.Add(massa);
                return Ok(new
                {
                    message = $"Massa '{massa.Nome}' Adicionado com Sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // DELETE: api/Massas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMassa(int id)
        {
            var massa = await _massaRepository.GetById(id);
            if (massa == null)
            {
                return NotFound();
            }

            await _massaRepository.Delete(id);

            return Ok(new
            {
                message = $"Massa '{massa.Nome}' Excluido com Sucesso"
            });
        }

    }
}
