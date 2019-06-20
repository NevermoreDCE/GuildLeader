using System;
using System.Collections.Generic;
using System.Text;

namespace GuildLeader
{
    public class Phase
    {
        public Phase()
        {
            SecondaryEffects = new List<SecondaryEffect>();
        }
        public int DpsToTank { get; set; }
        public int DpsToRaid { get; set; }
        public int Hitpoints { get; set; }
        public int Ticks { get; set; }
        public List<SecondaryEffect> SecondaryEffects { get; set; }
    }
}
