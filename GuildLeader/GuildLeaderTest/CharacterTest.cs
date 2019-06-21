using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildLeaderTest
{
    [TestClass]
    public class CharacterTest
    {
        [TestMethod]
        public void Instantiate_Default()
        {
            //arrange
            //act
            var character = new GuildLeader.Character();
            //assert
            Assert.IsNotNull(character);
            Assert.IsInstanceOfType(character, typeof(GuildLeader.Character));
        }
    }
}
