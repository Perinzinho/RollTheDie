using System;
using RollTheDie.Domain.Interface;

public class CharacterAttributeRepository : ICharacterRepository
{
    private readonly List<CharacterAttribute> _characterAttribute = new();

    public void Create(CharacterAttribute characterAttribute)
    {
        _characterAttribute.Add(characterAttribute);
    }

    public void
}
