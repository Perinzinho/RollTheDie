using System;
using RollTheDie.Domain.Entities;

public interface ICharacter
{
    void Add(Character character);
    Character GetById(Guid id);
    List<Character> GetAll();
    void Delete(Guid id);
}
