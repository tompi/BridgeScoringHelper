﻿namespace Scoring.Score
{
    // http://www.pagat.com/boston/bridge.html#chicago - rus
    public static class RussianIMPCalculator
    {

        public static int GetIMP(int result, int HCP, bool vulnerable,
                bool opponentsVulnerable)
        {
            int expectedResult = GetExpectedResult(HCP, result > 0 ? vulnerable
                    : opponentsVulnerable);
            return IMPCalculator.GetNorthSouthIMP(result, expectedResult);
            // return result >= expectedResult ? IMPs * -1 in IMPs;
        }

        public static int GetExpectedHCP(int result, bool vulnerable)
        {
            int factor = 1;
            if (result < 0)
            {
                factor = -1;
                result = result * -1;
            }
            int i = 0;
            short[] results = vulnerable ? ExpectedResultVulnerable
                    : ExpectedResultNonVulnerable;
            while (i < 20 && result > results[i])
                i++;
            return (i * factor) + 20;
        }

        public static int GetExpectedResult(int HCP, bool vulnerable)
        {
            int HCPIndex = HCP - 20;
            if (HCPIndex == 0)
                return 0;
            int factor = 1;
            if (HCPIndex < 0)
            {
                factor = -1;
                HCPIndex = HCPIndex * -1;
            }
            short[] results = vulnerable ? ExpectedResultVulnerable
                    : ExpectedResultNonVulnerable;
            return results[HCPIndex - 1] * factor;
        }

        private static readonly short[] ExpectedResultNonVulnerable = { 50, 70, 110,
            200, 300, 350, 400, 430, 460, 490, 600, 700, 900, 1000, 1100, 1200,
            1300, 1300, 1300, 1300 };
        private static readonly short[] ExpectedResultVulnerable = { 50, 70, 110, 290,
            440, 520, 600, 630, 660, 690, 900, 1050, 1350, 1500, 1650, 1800,
            1950, 1950, 1950, 1950 };

    }
}