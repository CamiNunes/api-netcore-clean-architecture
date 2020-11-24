using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Application.Querys.GetUser
{
    public class UserSkillViewModel
    {
        public UserSkillViewModel(string description)
        {
            this.description = description;
        }

        public string description { get; private set; }
    }
}
