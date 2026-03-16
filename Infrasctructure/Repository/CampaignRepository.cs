using System;
using RollTheDie.Domain.Interface;

public class CampaignRepository : ICampaign
{
    private readonly List<Campaign> _campaign = new();

    public void Create(Campaign campaign)
    {
        _campaign.Add(campaign);
    }

    public Campaign GetCampaigntById(Guid id)
    {
        return _campaign.FirstOrDefault(p => p.Id == id);
    }

    public List<Campaign> GetAll()
    {
        return _campaign.ToList();
    }

    public void Delete(Guid id)
    {
        var campaign = GetCampaigntById(id);

        if(campaign != null)
        {
            _campaign.Remove(campaign);
        }
    }
}
