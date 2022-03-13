﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApplication
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short FoundationYear { get; set; }
        public ICollection<Player> Players { get; set; }

        public ICollection<Sponsor> Sponsors { get; set; }
    }
}
