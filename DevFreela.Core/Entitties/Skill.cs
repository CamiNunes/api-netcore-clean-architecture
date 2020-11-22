using System;

namespace DevFreela.Core.Entitties
{
    public class Skill : BaseEntity
    {
        public Skill(string description)
        {
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public DateTime CreatedAt { get; private set; }

        public string Description { get; private set; }
    }
}
