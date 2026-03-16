using System;
using RollTheDie.Domain.Entities;

public interface ICampaign
{
    void Create(Campaign campaign);
    Campaign GetCampaigntById(Guid id);
    List<Campaign> GetAll();
    void Delete(Guid id);
}
