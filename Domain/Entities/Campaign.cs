using System;

namespace RollTheDie.Domain.Entities
{
    public class Campaign
    {

        public Guid Id { get; private set; }


        public string Name { get; set; }


        public string Description { get; set; }


        public Campaign(string name, string description)
        {
            Id = Guid.NewGuid(); 
            Name = name;
            Description = description;
        }

    }
}