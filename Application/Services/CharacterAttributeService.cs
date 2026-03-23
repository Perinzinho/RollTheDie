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



        }
    }
}
