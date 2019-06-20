using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuildLeaderTest
{
    [TestClass]
    public class RaidTest
    {
        [TestMethod]
        public void Instantiate_Default()
        {
            //arrange
            //act
            var raid = new GuildLeader.Raid();
            //assert
            Assert.IsNotNull(raid);
            Assert.IsInstanceOfType(raid,typeof(GuildLeader.Raid));
        }

        [TestMethod]
        public void CanAddBossToRaid()
        {
            //arrange
            var raid = new GuildLeader.Raid();
            var boss = new GuildLeader.Boss();
            //act
            raid.Bosses.Add(boss);
            //assert
            Assert.IsNotNull(raid.Bosses);
            Assert.IsTrue(raid.Bosses.Count == 1);
        }

    }
}
