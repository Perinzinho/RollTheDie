using System;
using RollTheDie.Domain.Entities;

public class CampaignRepository : ICampaign
{
    private readonly List<Campaign> _campaign = new();

    public async Task Create(Campaign campaign)
    {
        _campaign.Add(campaign);
    }

    public async Task<Campaign?> GetCampaigntById(Guid id)
    {
        return _campaign.FirstOrDefault(p => p.Id == id);
    }

    public async Task<List<Campaign>> GetAll()
    {
        return _campaign.ToList();
    }

    public async Task Delete(Guid id)
    {
        var campaign = await GetCampaigntById(id);

        if(campaign != null)
        {
            _campaign.Remove(campaign);
        }
       
    }
}
