using System;
using RollTheDie.Domain.Entities;

public class CharacterRepository : ICharacter
{
    private readonly List<Character> _character = new();

    public async Task Create(Character character)
    {
        _character.Add(character);
    }

    public async Task<Character?> GetCharacterById(Guid id)
    {
        return _character.FirstOrDefault(p => p.Id == id);
    }

    public async Task <List<Character>> GetAll()
    {
        return _character.OrderBy(p => p.Id).ToList();
    }

    public async Task Delete(Guid id)
    {
        var character = await GetCharacterById(id);

        if(character != null)
        {
            _character.Remove(character);
        }
    }
}
