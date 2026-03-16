using System;
using RollTheDie.Domain.Entities;

public class CharacterAttributeRepository : ICharacterAttribute
{
    private readonly List<CharacterAttribute> _characterAttribute = new();

    public void Create(CharacterAttribute characterAttribute)
    {
        _characterAttribute.Add(characterAttribute);
    }

    public void
}
