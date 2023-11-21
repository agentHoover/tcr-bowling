using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class BowlingGameTest
    {
        [TestMethod]
        public void TestGutterGame()
        {
            var game = new Game();
            for (var i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            game.Score().Should().Be(0);

        }
    }
}