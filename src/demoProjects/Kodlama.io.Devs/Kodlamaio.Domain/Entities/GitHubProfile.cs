﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GitHubProfile : Entity
    {
        public string Name { get; set; }
        public int DevelopmenId { get; set; }
        public virtual Developer Developer { get; set; }
        public string ProfilUrl { get; set; }

        public GitHubProfile()
        {
        }

        public GitHubProfile(int developmenId, string name, string profilUrl)
        {
            DevelopmenId = developmenId;
            Name = name;
            ProfilUrl = profilUrl;
        }
    }
}
