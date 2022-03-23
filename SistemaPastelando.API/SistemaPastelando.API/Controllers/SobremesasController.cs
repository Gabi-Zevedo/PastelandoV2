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
    public class SobremesasController : ControllerBase
    {
        private readonly ISobremesaRepository _sobremesaRepository;

        public SobremesasController(ISobremesaRepository sobremesaRepository)
        {
            _sobremesaRepository = sobremesaRepository;
        }

        // GET: api/Sobremesas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sobremesa>>> GetSobremesas()
        {
            return await _sobremesaRepository.GetAll().ToListAsync();
        }

        // GET: api/Sobremesas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sobremesa>> GetSobremesa(int id)
        {
            var sobremesa = await _sobremesaRepository.GetById(id);

            if (sobremesa == null)
            {
                return NotFound();
            }

            return sobremesa;
        }

        // PUT: api/Sobremesas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSobremesa(int id, Sobremesa sobremesa)
        {

            if (id != sobremesa.SobremesaId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _sobremesaRepository.Update(sobremesa);
                return Ok(new
                {
                    message = $"{sobremesa.Nome} Atualizado com sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // POST: api/Sobremesas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sobremesa>> PostSobremesa(Sobremesa sobremesa)
        {
            if (ModelState.IsValid)
            {
                await _sobremesaRepository.Add(sobremesa);
                return Ok(new
                {
                    message = $"{sobremesa.Nome} Adicionado com Sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // DELETE: api/Sobremesas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSobremesa(int id)
        {
            var sobremesa = await _sobremesaRepository.GetById(id);
            if (sobremesa == null)
            {
                return NotFound();
            }

            await _sobremesaRepository.Delete(id);

            return Ok(new
            {
                message = $"{sobremesa.Nome} Excluido com Sucesso"
            });
        }

    }
}
