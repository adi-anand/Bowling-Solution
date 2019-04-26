namespace BowlingBall
{
    public class SpareFrame : Frame
    {
        public SpareFrame(int fistRoll, int secondRoll)
            : base(fistRoll, secondRoll) { }

        public override int GetFrameScore()
        {
            return 10 + NextFrame.FirstRoll;
        }
    }
}
