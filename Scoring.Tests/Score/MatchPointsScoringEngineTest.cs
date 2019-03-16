using System.Collections.Generic;
using Scoring.Game;
using Scoring.Players;
using Scoring.Score;
using Xunit;

namespace Scoring.Tests.Score
{
    public class MatchPointsScoringEngineTest
    {
        private List<Result> smallResult;
        private Result res1;
        private Result res2;
        private Result res3;
        private MatchPointsScoringEngine engine = new MatchPointsScoringEngine();
        private Result GetEmptyResult()
        {
            return new Result(new Contract(), new Board(1), new Table());
        }
        public MatchPointsScoringEngineTest()
        {
            smallResult = new List<Result>();
            res1 = GetEmptyResult();
            res1.NorthSouthPoints = 100;
            smallResult.Add(res1);
            res2 = GetEmptyResult();
            res2.NorthSouthPoints = 500;
            smallResult.Add(res2);
            res3 = GetEmptyResult();
            res3.NorthSouthPoints = 500;
            smallResult.Add(res3);
            engine.ScoreBoard(smallResult);
        }

        [Fact]
        public void testScoreBoard_2xminus400_equals_0()
        {
            Assert.Equal(0, (int)res1.NorthSouthScore);
        }
        [Fact]
        public void testScoreBoard_1x400and1xequal_equals_3()
        {
            Assert.Equal(3, (int)res2.NorthSouthScore);
        }

    }
}