using System.Collections.Generic;

namespace Scoring.Score
{
    public class IMPsAcrossScoringEngine : IScoringEngine
    {
        public void ScoreBoard(List<Result> results)
        {
            for (int i = 0; i < results.Count; i++)
            {
                int nsScore = 0;
                Result result = results[i];
                int nsPoints = result.NorthSouthPoints;
                for (int j = 0; j < results.Count; j++)
                {
                    if (j != i)
                    {
                        int nsPointsTableB = results[j].NorthSouthPoints;
                        nsScore += IMPCalculator.GetNorthSouthIMP(nsPoints, nsPointsTableB);
                    }
                }
                result.NorthSouthScore = (double)nsScore;
            }

        }
    }
}