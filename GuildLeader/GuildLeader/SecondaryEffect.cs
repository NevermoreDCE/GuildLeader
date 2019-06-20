using System;
using System.Collections.Generic;
using System.Text;

namespace GuildLeader
{
    public class SecondaryEffect
    {
        public int DpsToTank { get; set; }
        public int DpsToRaid { get; set; }
        public int Hitpoints { get; set; }
        public string ShutoffTrigger { get; set; }
        public int Ticks { get; set; }
    }
}
