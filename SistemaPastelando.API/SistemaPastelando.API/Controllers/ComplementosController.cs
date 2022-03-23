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
    public class ComplementosController : ControllerBase
    {
        private readonly IComplementoRepository _complementoRepository;

        public ComplementosController(IComplementoRepository complementoRepository)
        {
            _complementoRepository = complementoRepository;
        }

        // GET: api/Complementos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Complemento>>> GetComplementos()
        {
            return await _complementoRepository.GetAll().ToListAsync();
        }

        // GET: api/Complementos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Complemento>> GetComplemento(int id)
        {
            var complemento = await _complementoRepository.GetById(id);

            if (complemento == null)
            {
                return NotFound();
            }

            return complemento;
        }

        // PUT: api/Complementos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplemento(int id, Complemento complemento)
        {

            if (id != complemento.ComplementoId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _complementoRepository.Update(complemento);
                return Ok(new
                {
                    message = $"{complemento.Nome} Atualizado com sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // POST: api/Complementos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Complemento>> PostComplemento(Complemento complemento)
        {
            if (ModelState.IsValid)
            {
                await _complementoRepository.Add(complemento);
                return Ok(new
                {
                    message = $"{complemento.Nome} Adicionado com Sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // DELETE: api/Complementos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplemento(int id)
        {
            var complemento = await _complementoRepository.GetById(id);
            if (complemento == null)
            {
                return NotFound();
            }

            await _complementoRepository.Delete(id);

            return Ok(new
            {
                message = $"{complemento.Nome} Excluido com Sucesso"
            });
        }

    }
}
