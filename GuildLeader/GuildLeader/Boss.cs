using System.Collections.Generic;

namespace GuildLeader
{
    public class Boss
    {
        public Boss()
        {
            Phases = new List<Phase>();
        }
        public string Name { get; set; }
        public int Ticks { get; set; }
        public List<Phase> Phases { get; set; }
    }
}