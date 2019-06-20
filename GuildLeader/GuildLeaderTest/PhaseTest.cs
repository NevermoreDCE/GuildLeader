using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildLeaderTest
{
    [TestClass]
    public class PhaseTest
    {
        [TestMethod]
        public void Instantiate_Default()
        {
            //arrange
            //act
            var phase = new GuildLeader.Phase();
            //assert
            Assert.IsNotNull(phase);
            Assert.IsInstanceOfType(phase, typeof(GuildLeader.Phase));
        }
        [TestMethod]
        public void SetProperties_NotSecondaryEffects()
        {
            //arrange
            var phase = new GuildLeader.Phase();
            int dpsToTank = 99;
            int dpsToRaid = 88;
            int hitpoints = 77;
            int ticks = 66;
            // act
            phase.DpsToTank = dpsToTank;
            phase.DpsToRaid = dpsToRaid;
            phase.Hitpoints = hitpoints;
            phase.Ticks = ticks;
            //assert
            Assert.AreEqual(phase.DpsToTank, dpsToTank);
            Assert.AreEqual(phase.DpsToRaid, dpsToRaid);
            Assert.AreEqual(phase.Hitpoints, hitpoints);
            Assert.AreEqual(phase.Ticks, ticks);
        }
        [TestMethod]
        public void CanAddSecondaryEffect()
        {
            //arrange
            var phase = new GuildLeader.Phase();
            var secondaryEffect = new GuildLeader.SecondaryEffect();
            //act
            phase.SecondaryEffects.Add(secondaryEffect);
            //assert
            Assert.IsNotNull(phase.SecondaryEffects);
            Assert.IsTrue(phase.SecondaryEffects.Count == 1);
        }
    }
}
