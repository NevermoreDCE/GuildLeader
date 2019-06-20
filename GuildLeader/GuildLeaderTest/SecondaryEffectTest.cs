using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildLeaderTest
{
    [TestClass]
    public class SecondaryEffectTest
    {
        [TestMethod]
        public void Instantiate_Default()
        {
            //arrange
            //act
            var secondaryEffect = new GuildLeader.SecondaryEffect();
            //assert
            Assert.IsNotNull(secondaryEffect);
            Assert.IsInstanceOfType(secondaryEffect, typeof(GuildLeader.SecondaryEffect));
        }
        [TestMethod]
        public void SetProperties()
        {
            //arrange
            var secondaryEffect = new GuildLeader.SecondaryEffect();
            var dpsToTank = 99;
            var dpsToRaid = 88;
            var hitpoints = 77;
            var shutoffTrigger = "Kick";
            var ticks = 66;
            //act
            secondaryEffect.DpsToTank = dpsToTank;
            secondaryEffect.DpsToRaid = dpsToRaid;
            secondaryEffect.Hitpoints = hitpoints;
            secondaryEffect.ShutoffTrigger = shutoffTrigger;
            secondaryEffect.Ticks = ticks;
            //assert
            Assert.AreEqual(secondaryEffect.DpsToTank, dpsToTank);
            Assert.AreEqual(secondaryEffect.DpsToRaid, dpsToRaid);
            Assert.AreEqual(secondaryEffect.Hitpoints, hitpoints);
            Assert.AreEqual(secondaryEffect.ShutoffTrigger, shutoffTrigger);
            Assert.AreEqual(secondaryEffect.Ticks, ticks);
        }

    }
}
