using RollTheDie.Domain.Entities;
namespace RollTheDie.Application.Services
{
    public class CharacterService
    {
        private readonly ICharacter _character;

        public CharacterService(ICharacter character)
        {
            _character = character;
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
            
        }

    }
}
