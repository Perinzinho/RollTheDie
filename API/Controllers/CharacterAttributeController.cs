using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RollTheDie.Application.Services;
using RollTheDie.Domain.Entities;

namespace RollTheDie.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CharacterAttributeController :ControllerBase
    {
        private readonly CharacterAttributeService _characterAttributeService;

        public CharacterAttributeController(CharacterAttributeService characterAttributeService)
        {
            _characterAttributeService = characterAttributeService;
        }


        [HttpPost]
        public async Task<IActionResult> Create(CharacterAttribute characterAttribute)
        {
            try
            {
                await _characterAttributeService.Create(characterAttribute);
                return Ok("Personagem criado com sucesso");
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByCharacterId(Guid id)
        {
            try
            {
                return Ok(await _characterAttributeService.GetByCharacterId(id));
            }
            catch (ArgumentException ex) {
                return BadRequest(ex.Message);
            }   
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id) {
            try
            {
                await _characterAttributeService.Delete(id);
                return Ok("Personagem Deletado com Sucesso");
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);  
            }
        }
    }

}
