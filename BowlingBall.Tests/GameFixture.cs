using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();
             Roll(game, 0, 20);
           // Roll(game);
            var score = game.GetScore();
            Assert.AreEqual(65, game.GetScore());
        }

        [TestMethod]
        public void NoAnyFrameIsSpareOrStrike_ScoreShouldBe_65()
        {
            var list = new int[] { 0, 1, 2, 3, 3, 4, 5, 1, 7, 2, 3, 6, 9, 0, 2, 7, 3, 4, 5, 3 };
            var game = new Game();
            Roll(game, list);
            Assert.AreEqual(65, game.GetScore());
        }

        [TestMethod]
        public void FirstFrameIsStrike_ScoreShouldBe_65()
        {
            var list = new int[] { 10, 0, 1, 2, 3, 4, 5, 5, 4, 3, 2, 1, 0, 1, 9, 4, 3, 2, 1 };
            var game = new Game();
            Roll(game, list);
            var score = game.GetScore();
            Assert.AreEqual(65, game.GetScore());
        }

        [TestMethod]
        public void FirstFrameIsSpare_ScoreShouldBe_94()
        {
            var list = new int[] { 1,9,1,2,3,4,5,5,6,3,10,9,0,6,2,1,5,4,2};
            var game = new Game();
            Roll(game, list);
            var score = game.GetScore();
            Assert.AreEqual(94, game.GetScore());
        }

        [TestMethod]
        public void LastFrameIsSpare_ScoreShouldBe_187()
        {
            var list = new int[] { 10, 9, 1, 5, 5, 7, 2, 10, 10, 10, 9, 0, 8, 2, 9, 1, 10 };
            var game = new Game();
            Roll(game, list);
            var score = game.GetScore();
            Assert.AreEqual(187, game.GetScore());
        }

        [TestMethod]
        public void LastFrameIsStrike_ScoreShouldBe_188()
        {
            var list = new int[] { 10, 9, 1, 5, 5, 7, 2, 10, 10, 10, 9, 0, 8, 2, 10, 1, 9 }; 
            var game = new Game();
            Roll(game, list);
            var score = game.GetScore();
            Assert.AreEqual(65, game.GetScore());
        }
        private void Roll(Game game, int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }

        private void Roll(Game game, int[] list)
        {
            foreach (var pins in list)
            {
                game.Roll(pins);
            }
           
        }
    }
}
