using RollTheDie.Domain.Interfaces;
using RollTheDie.Domain.Entities;

namespace RollTheDie.Application.Services
{
    public class CharacterAttributeService
    {

        private readonly ICharacterAttributeRepository _characterAttribute;
        private readonly ICharacter _character;

        public CharacterAttributeService(ICharacterAttributeRepository characterAttribute, ICharacter character)
        {
            _characterAttribute = characterAttribute;
            _character = character;
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
            var characterId= await _character.GetCharacterById(characterAttribute.CharacterId);
            if (characterId == null)
            {
                throw new Exception("Personagem não existe");
            }
            

            if(characterAttribute.NEX<0 || characterAttribute.NEX > 99)
            {
                throw new Exception("NEX não pode ser menor que 0% ou maior que 99%");
            }

            if(characterAttribute.NEX % 5 != 0)
            {
                throw new Exception("NEX deve ser de 5 em 5%!");
            }
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
            await _character.Delete(id);



        }
    }
}
