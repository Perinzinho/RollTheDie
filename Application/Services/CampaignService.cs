using RollTheDie.Domain.Interfaces;
using RollTheDie.Domain.Entities;

namespace RollTheDie.Application.Services
{
    public class CampaignService
    {
        private readonly ICampaign _campaign;

        public CampaignService(ICampaign campaign)
        {
            _campaign = campaign;
        }

        public async Task Create(Campaign campaign)
        {
            if (campaign.Name.Length > 50)
            {
                throw new Exception("Nome da Campanha não pode ser maior que 50 caracteres");
            }
            await _campaign.Create(campaign);
        }

        public async Task<Campaign?> GetCampaign(Guid id)
        {

            if (_campaign == null)
            {
                throw new Exception("Campanha não existe");
            }

            return await _campaign.GetCampaigntById(id);
        }

        public async Task<List<Campaign>> GetAll()
        {
            if (_campaign == null)
            {
                throw new Exception("Nenhuma Campanha Encontrad");
            }
            return await _campaign.GetAll();
        }

        public async Task Delete(Guid id)
        {
            var campaign = await GetCampaign(id);
            if (campaign == null)
            {
                throw new Exception("Campanha não existe");
            }
            await _campaign.Delete(id);
        }
    }
}
