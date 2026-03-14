using System;
using RollTheDie.Domain.Entities;

public interface ICampaign
{
    void Add(Campaign campaign);
    Campaign GetById(Guid id);
    List<Campaign> GetAll();
    void Delete(Guid id);
}
