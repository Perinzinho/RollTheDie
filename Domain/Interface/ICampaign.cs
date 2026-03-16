using System;
using RollTheDie.Domain.Entities;

public interface ICampaign
{
    Task Create(Campaign campaign);
    Task<Campaign?> GetCampaigntById(Guid id);
    Task<List<Campaign>> GetAll();
    Task Delete(Guid id);
}
