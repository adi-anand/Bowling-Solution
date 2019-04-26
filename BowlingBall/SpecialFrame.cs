namespace BowlingBall
{
    public class SpecialFrame : Frame
    {
        private int ThirdRoll;
        public SpecialFrame(int firstRoll, int secondRoll, int thirdRoll) :
            base(firstRoll, secondRoll)
        {
            ThirdRoll = thirdRoll;
        }

        public override int GetFrameScore()
        {
            return FirstRoll + SecondRoll + ThirdRoll;
        }
    }
}
