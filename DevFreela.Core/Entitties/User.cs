using System;
using System.Collections.Generic;

namespace DevFreela.Core.Entitties
{
    public class User : BaseEntity
    {
        public User(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = DateTime.Now;
            Skills = new List<UserSkill>();
            ProvidedServices = new List<ProvidedService>();
            OwningProvidedServices = new List<ProvidedService>();
        }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public List<UserSkill> Skills { get; private set; }

        public List<ProvidedService> ProvidedServices { get; private set; }

        public List<ProvidedService> OwningProvidedServices { get; private set; }
    }
}
