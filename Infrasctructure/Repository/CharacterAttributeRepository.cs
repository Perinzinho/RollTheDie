using System;
using RollTheDie.Domain.Entities;
using RollTheDie.Domain.Interfaces;

public class CharacterAttributeRepository : ICharacterAttributeRepository
{
    private readonly List<CharacterAttribute> _characterAttribute = new();
    private readonly List<Character> _character = new();

    public async Task<Character?> GetByCharacterId(Guid id)
    {
        return _character.FirstOrDefault(p => p.Id == id);
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
            _character.Remove(character);
        }
    }
}
