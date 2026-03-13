using System;

namespace RollTheDie.Domain.Entities
{
    public class Character
    {
        public Guid Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Backstory { get; set; }
        public string Personality { get; set; }
        public bool IsNPC { get; set; }
        public Guid CampaignId { get; set; }
        public Campaign Campaign { get; set; }

        public Character(string firstName, string lastName, string backstory, string personality, bool isNPC, Guid campaignId, Campaign campaign)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Backstory = backstory;
            Personality = personality;
            IsNPC = isNPC;
            CampaignId = campaignId;
            Campaign = campaign;
        }
    }
}