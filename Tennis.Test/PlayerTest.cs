using Tennis.Application.Repository;

namespace Tennis.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repo = new PlayersRepository();

            var player = repo.GetAsync(52).Result;

            Assert.IsNotNull(player);
            Assert.IsTrue(player.Id is 52);
        }
    }
}