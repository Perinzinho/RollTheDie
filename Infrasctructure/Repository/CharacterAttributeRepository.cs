using System;
using RollTheDie.Domain.Entities;
using RollTheDie.Domain.Interfaces;

public class CharacterAttributeRepository : ICharacterAttributeRepository
{
    private readonly List<CharacterAttribute> _characterAttribute = new();

    public async Task<CharacterAttribute?> GetByCharacterId(Guid id)
    {
        return _characterAttribute.FirstOrDefault(p => p.CharacterId == id);
    }

    public async Task Create(CharacterAttribute characterAttribute)
    {
        _characterAttribute.Add(characterAttribute);
    }

    public async Task Update(CharacterAttribute characterAttribute)
    {
        

    }
    public async Task Delete(Guid id)
    {
        var character = await GetByCharacterId(id);

        if (character != null)
        {
            _characterAttribute.Remove(character);
        }
        
    }
}
