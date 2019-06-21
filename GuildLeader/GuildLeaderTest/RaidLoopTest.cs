using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildLeaderTest
{
    [TestClass]
    public class RaidLoopTest
    {
        [TestMethod]
        public void Instantiate_Default()
        {
            //arrange
            //act
            var raidloop = new GuildLeader.RaidLoop();
            //assert
            Assert.IsNotNull(raidloop);
            Assert.IsInstanceOfType(raidloop, typeof(GuildLeader.RaidLoop));
        }
        [TestMethod]
        public void AddRaid()
        {
            //arrange
            var raidloop = new GuildLeader.RaidLoop();
            var raid = new GuildLeader.Raid();
            //act
            raidloop.Raid = raid;
            //assert
            Assert.IsNotNull(raidloop.Raid);
            Assert.IsTrue(raidloop.Raid == raid);
        }
        [TestMethod]
        public void AddParty()
        {
            
        }
        [TestMethod]
        public void StartRaid()
        {
            //arrange
            var raidloop = new GuildLeader.RaidLoop();
            var raid = new GuildLeader.Raid();
            raidloop.Raid = raid;
            //act
            
        }
    }
}
