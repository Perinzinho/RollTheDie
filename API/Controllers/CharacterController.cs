using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RollTheDie.Application.Services;
using RollTheDie.Domain.Entities;

namespace RollTheDie.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly CharacterService _characterService;

        public CharacterController(CharacterService characterService) {
            _characterService = characterService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Character character)
        {
            try
            {
                await _characterService.Create(character);
                return Ok("Personagem criado Criada com sucesso");
            }
            catch (ArgumentException ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _characterService.GetAll());
            }
            catch (ArgumentException ex) {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharacterById(Guid id)
        {
            try
            {
                return Ok(await _characterService.GetCharacter(id));
            }
            catch (ArgumentException ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id) {
            try
            {
                await _characterService.Delete(id);
                return Ok("Personagem Deletado com sucesso");
            }
            catch (ArgumentException ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}

