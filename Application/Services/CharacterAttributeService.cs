using RollTheDie.Domain.Interfaces;
using RollTheDie.Domain.Entities;

namespace RollTheDie.Application.Services
{
    public class CharacterAttributeService
    {

        private readonly ICharacterAttributeRepository _characterAttribute;

        public CharacterAttributeService(ICharacterAttributeRepository characterAttribute)
        {
            _characterAttribute = characterAttribute;
        }

        public async Task<CharacterAttribute?> GetByCharacterId(Guid id)
        {
            if (_characterAttribute == null)
            {
                throw new Exception("Personagem não  existe");
            }

            return await _characterAttribute.GetByCharacterId(id);
        }

        public async Task Create(CharacterAttribute characterAttribute)
        {
            await _characterAttribute.Create(characterAttribute);

            //ver as regras do sistema para criação de personagem
        }

        public async Task Delete(Guid id)
        {
            var character = await GetByCharacterId(id);

            if (character == null)
            {
                throw new Exception("Personagem não existe");
            }

            await _characterAttribute.Delete(id);



        }
    }
}
