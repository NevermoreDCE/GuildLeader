using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildLeaderTest
{
    [TestClass]
    public class PartyTest
    {
        [TestMethod]
        public void Instantiate_Default()
        {
            //arrange
            //act
            var party = new GuildLeader.Party();
            //assert
            Assert.IsNotNull(party);
            Assert.IsInstanceOfType(party,typeof(GuildLeader.Party));
        }
        [TestMethod]
        public void AddCharacter()
        {
            //arrange
            var party = new GuildLeader.Party();
            var character = new GuildLeader.Character();
            //act
            party.Members.Add(character);
            //assert
            Assert.IsNotNull(party.Members);
            Assert.IsTrue(party.Members.Count == 1);
        }
    }
}
