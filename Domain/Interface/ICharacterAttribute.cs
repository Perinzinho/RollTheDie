using RollTheDie.Domain.Entities;

namespace RollTheDie.Domain.Interfaces
{
    public interface ICharacterAttributeRepository
    {//Porquê aqui é categorizado como task?
        Task<CharacterAttribute?> GetByCharacterId(Guid characterId);

        Task Create(CharacterAttribute attributes);

        Task Update(CharacterAttribute attributes);//Deve ser Patch, não pode ser PUT

        Task Delete(Guid characterId);
    }
}