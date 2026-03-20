using System;
using RollTheDie.Domain.Entities;

public interface ICharacter
{//Todo- Add Update Task
    Task Create(Character character);
    Task<Character?> GetCharacterById(Guid id);
    Task<List<Character>> GetAll();
    Task Delete(Guid id);
}
