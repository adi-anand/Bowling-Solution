namespace BowlingBall
{
    public abstract class Frame
    {
        public int FirstRoll;
        public int SecondRoll;
        public Frame NextFrame;

        protected Frame(int firstroll, int secondroll)
        {
            FirstRoll = firstroll;
            SecondRoll = secondroll;
        }
        public abstract int GetFrameScore();
    }
}
