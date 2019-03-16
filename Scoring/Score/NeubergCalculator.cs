using System;

namespace Scoring.Score
{
    public class NeubergCalculator
    {
        private double _neubergFactor;
        public NeubergCalculator(int numberOfTimesBoardWasPlayed, int numberOfTimesBoardShouldHaveBeenPlayed)
        {
            _neubergFactor = (double)numberOfTimesBoardShouldHaveBeenPlayed / (double)numberOfTimesBoardWasPlayed;
        }


        public int GetAdjustedScoreTimes10(double actualScore)
        {
            double adjustedScore = ((actualScore + (double)1) * _neubergFactor) - (double)1;
            // Round to 1 decimal
            return (int)Math.Round(adjustedScore * 10);
        }
    }
}