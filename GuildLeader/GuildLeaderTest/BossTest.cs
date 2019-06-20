using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildLeaderTest
{
    [TestClass]
    public class BossTest
    {
        [TestMethod]
        public void Instantiate_Default()
        {
            //arrange
            //act
            var boss = new GuildLeader.Boss();
            //assert
            Assert.IsNotNull(boss);
            Assert.IsInstanceOfType(boss, typeof(GuildLeader.Boss));
        }
        [TestMethod]
        public void SetProperties_NotPhases()
        {
            //arrange
            var boss = new GuildLeader.Boss();
            string bossName = "TestBoss";
            int bossTicks = 99;
            //act
            boss.Name = bossName;
            boss.Ticks = bossTicks;
            //assert
            Assert.AreEqual(bossName,boss.Name);
            Assert.AreEqual(bossTicks, boss.Ticks);
        }
        [TestMethod]
        public void CanAddPhase()
        {
            //arrange
            var boss = new GuildLeader.Boss();
            var phase = new GuildLeader.Phase();
            //act
            boss.Phases.Add(phase);
            //assert
            Assert.IsNotNull(boss.Phases);
            Assert.IsTrue(boss.Phases.Count == 1);
        }
    }
}
