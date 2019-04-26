using System.Collections.Generic;

namespace BowlingBall
{
    public class Game
    {
        public Game() { }

        FrameCreater creater = new FrameCreater();
        List<Frame> frames = new List<Frame>();
        public void Roll(int pins)
        {
            var frame = creater.CreateFrame(pins);
            if (frame != null)
                frames.Add(frame);
            // Add your logic here. Add classes as needed.
        }

        public int GetScore()
        {
            int score = 0;
            // Returns the final score of the game.
            LinkFrames();
            foreach (var frame in frames)
            {
                score += frame.GetFrameScore();
            }

            return score;
        }

        private void LinkFrames()
        {
            for (int i = 0; i < 9; i++)
            {
                frames[i].NextFrame = frames[i + 1];
            }
        }
    }
}

   



