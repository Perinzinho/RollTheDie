using System;
using RollTheDie.Domain.Entities;

public interface ICampaign
{
    void Create(Campaign campaign);
    Campaign GeCampaigntById(Guid id);
    List<Campaign> GetAll();
    void Delete(Guid id);
}
