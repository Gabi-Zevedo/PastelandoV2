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
    public class OutrosItensController : ControllerBase
    {
        private readonly IOutroItemRepository _outroItemRepository;

        public OutrosItensController(IOutroItemRepository outroItemRepository)
        {
            _outroItemRepository = outroItemRepository;
        }

        // GET: api/OutrosItens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OutroItem>>> GetOutrosItens()
        {
            return await _outroItemRepository.GetAll().ToListAsync();
        }

        // GET: api/OutrosItens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OutroItem>> GetOutroItem(int id)
        {
            var outroItem = await _outroItemRepository.GetById(id);

            if (outroItem == null)
            {
                return NotFound();
            }

            return outroItem;
        }

        // PUT: api/OutrosItens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOutroItem(int id, OutroItem outroItem)
        {

            if (id != outroItem.OutroItemId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _outroItemRepository.Update(outroItem);
                return Ok(new
                {
                    message = $"{outroItem.Nome} Atualizado com sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // POST: api/OutrosItens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OutroItem>> PostOutroItem(OutroItem outroItem)
        {
            if (ModelState.IsValid)
            {
                await _outroItemRepository.Add(outroItem);
                return Ok(new
                {
                    message = $"{outroItem.Nome} Adicionado com Sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // DELETE: api/OutrosItens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOutroItem(int id)
        {
            var outroItem = await _outroItemRepository.GetById(id);
            if (outroItem == null)
            {
                return NotFound();
            }

            await _outroItemRepository.Delete(id);

            return Ok(new
            {
                message = $"{outroItem.Nome} Excluido com Sucesso"
            });
        }

    }
}
