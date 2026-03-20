using RollTheDie.Domain.Interfaces;

namespace RollTheDie.Application.Services
{
    public class CampaignService
    {
        private readonly ICampaign _campaign;

        public CampaignService(ICampaign campaign) { 
            _campaign = campaign;
        }
    }
}
