namespace BowlingBall
{
    public class StrikeFrame : Frame
    {
        public StrikeFrame(int fistRoll, int secondRoll)
            : base(fistRoll, secondRoll) { }

        public override int GetFrameScore()
        {
            if (NextFrame is StrikeFrame)
                return 10 + NextFrame.FirstRoll + NextFrame.NextFrame.FirstRoll;
            else
                return 10 + NextFrame.FirstRoll + NextFrame.SecondRoll;
        }
    }
}
