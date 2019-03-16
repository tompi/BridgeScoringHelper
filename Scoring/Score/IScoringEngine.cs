using System.Collections.Generic;

namespace Scoring.Score
{
    public interface IScoringEngine
    {
        void ScoreBoard(List<Result> results);
    }
}