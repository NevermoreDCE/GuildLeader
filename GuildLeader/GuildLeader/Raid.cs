using System;
using System.Collections.Generic;
using System.Text;

namespace GuildLeader
{
    public class Raid
    {
        public Raid()
        {
            Bosses = new List<Boss>();
        }
        public List<Boss> Bosses { get; set; }
    }
}
