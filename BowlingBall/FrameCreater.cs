namespace BowlingBall
{
    public class FrameCreater
    {
        int prevRoll = 0;
        int currentRoll = 0;
        bool firstRoll = true;
        bool isStrikeSpecial;
        bool isSpecialFrame;
        int frameCount = 0;
        static int roll = 0;
        bool isSprareSpecial;
        public Frame CreateFrame(int pindowns)
        {
            Frame frame = null;
            // Handling last frame which would be spare or strike
            if (isSpecialFrame && frameCount == 10)
            {
                if (isSprareSpecial)
                    frame = new SpecialFrame(prevRoll, currentRoll, pindowns);
                else if (isStrikeSpecial && roll == 1)
                {
                    currentRoll = pindowns;
                    roll++;
                }
                else
                    frame = new SpecialFrame(prevRoll, currentRoll, pindowns);

            }
            else if (pindowns == 10)
            {
                frameCount++;
                if (frameCount == 10)
                {
                    // pindown is 10 and it is first roll of last frame
                    isSpecialFrame = true;
                    prevRoll = pindowns;
                    isStrikeSpecial = true;
                    roll++;
                }
                else
                    frame = new StrikeFrame(10, 0); // if pindown is 10 and it is not last frame
                if (frameCount != 10)
                    prevRoll = 0;

            }
            else if (firstRoll)
            {
                prevRoll = pindowns;
                firstRoll = false;
            }
            else
            {
                if (prevRoll + pindowns == 10)
                {
                    firstRoll = true;
                    frameCount++;
                    if (frameCount == 10)
                    {
                        // last frame and it is second roll, eligble for special frame
                        isSpecialFrame = true;
                        currentRoll = pindowns;
                        isSprareSpecial = true;
                    }
                    else
                        frame = new SpareFrame(prevRoll, pindowns); 
                }
                else
                {
                    firstRoll = true;
                    frameCount++;
                    frame = new NormalFrame(prevRoll, pindowns);
                }
                if (frameCount != 10)
                    prevRoll = 0;
            }

            return frame; ;
        }
    }
}
