using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaPastelando.BLL.Models;
using SistemaPastelando.DAL;
using SistemaPastelando.DAL.Interfaces;

namespace SistemaPastelando.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardapiosController : ControllerBase
    {
        private readonly ICardapioRepository _cardapioRepository;

        public CardapiosController(ICardapioRepository cardapioRepository)
        {
            _cardapioRepository = cardapioRepository;
        }

        // GET: api/Cardapios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cardapio>>> GetCardapios()
        {
            return await _cardapioRepository.GetAll().ToListAsync();
        }

        // GET: api/Cardapios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cardapio>> GetCardapio(int id)
        {
            var cardapio = await _cardapioRepository.GetById(id);

            if (cardapio == null)
            {
                return NotFound();
            }

            return cardapio;
        }

        // PUT: api/Cardapios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCardapio(int id, Cardapio cardapio)
        {

            if (id != cardapio.ItemId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _cardapioRepository.Update(cardapio);
                return Ok(new
                {
                    message = $"{cardapio.Nome} Atualizado com sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // POST: api/Cardapios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cardapio>> PostCardapio(Cardapio cardapio)
        {
            if (ModelState.IsValid)
            {
                await _cardapioRepository.Add(cardapio);
                return Ok(new
                {
                    message = $"{cardapio.Nome} Adicionado com Sucesso"
                });
            }

            return BadRequest(ModelState);
        }

        // DELETE: api/Cardapios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCardapio(int id)
        {
            var cardapio = await _cardapioRepository.GetById(id);
            if (cardapio == null)
            {
                return NotFound();
            }

            await _cardapioRepository.Delete(id);

            return Ok(new
            {
                message = $"{cardapio.Nome} Excluido com Sucesso"
            });
        }
        
    }
}
