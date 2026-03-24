using RollTheDie.Domain.Entities;
using RollTheDie.Domain.Interfaces;

namespace RollTheDie.Application.Services
{
    public class CharacterService
    {
        private readonly ICharacter _character;
        private readonly ICharacterAttributeRepository _characterAttribute;

        public CharacterService(ICharacter character, ICharacterAttributeRepository characterAttribute)
        {
            _character = character;
            _characterAttribute = characterAttribute;
        }

        public async Task Create(Character character)
        {
            if (character.FirstName.Length > 50)
            {
                throw new Exception("Nome não pode ser maior que 50 caracteres");
            }
            if (character.LastName.Length > 100)
            {
                throw new Exception("Sobrenome não pode ser maior que 100 caracteres");
            }
            await _character.Create(character);
        }

        public async Task<Character?> GetCharacter(Guid id)
        {
            if (_character == null)
            {
                throw new Exception("Personagem não existe");
            }

            return await _character.GetCharacterById(id);
        }

        public async Task<List<Character>> GetAll()
        {
            if (_character == null)
            {
                throw new Exception("Nenhum Personagem Encontrado");
            }
            return await _character.GetAll();
        }

        public async Task Delete(Guid id) {
            var character = await _character.GetCharacterById(id); 
            if (character == null) {
                throw new Exception("Personagem não existe");
            }
            await _character.Delete(id);
            await _characterAttribute.Delete(id);

        }

    }
}
