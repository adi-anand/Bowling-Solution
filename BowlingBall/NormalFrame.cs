namespace BowlingBall
{
    public class NormalFrame : Frame
    {
        public NormalFrame(int fistRoll, int secondRoll)
            : base(fistRoll, secondRoll) { }

        public override int GetFrameScore()
        {
            return FirstRoll + SecondRoll;
        }
    }
}
