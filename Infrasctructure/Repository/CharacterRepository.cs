using System;
using RollTheDie.Domain.Interface;

public class CharacterRepository : ICharacter
{
    private readonly List<Character> _character = new();

    public void Create(Character character)
    {
        _character.Add(character);
    }

    public Character GetCharacterById(Guid id)
    {
        return _character.FirstOrDefault(p => p.Id == id);
    }

    public List<Character> GetAll()
    {
        return _character.OrderBy(p => p.Id).ToList();
    }

    public void Delete(Guid id)
    {
        var character = GetCharacterById(id);

        if(character != null)
        {
            _campaign.Remove(campaign);
        }
    }
}
