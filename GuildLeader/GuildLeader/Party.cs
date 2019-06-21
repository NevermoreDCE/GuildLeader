using System;
using System.Collections.Generic;
using System.Text;

namespace GuildLeader
{
    public class Party
    {
        public Party()
        {
            Members = new List<Character>();
        }
        public List<Character> Members { get; set; }
    }
}
