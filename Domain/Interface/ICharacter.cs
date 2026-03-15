using System;
using RollTheDie.Domain.Entities;

public interface ICharacter
{
    void Create(Character character);
    Character GetChracterById(Guid id);
    List<Character> GetAll();
    void Delete(Guid id);
}
