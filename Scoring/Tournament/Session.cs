using System.Collections.Generic;
using Scoring.Game;
using Scoring.Players;
using Scoring.Score;

namespace Scoring.Tournament
{
    public class Session
    {
        public int Number;
        public List<Round> Rounds;

        public Session()
        {
            Rounds = new List<Round>();
        }

        public void AddContract(int roundNumber, Table table, Contract contract,
                int boardNumber)
        {
            Round round = GetRound(roundNumber);
            round.AddContract(contract, table, boardNumber);
        }

        public Round GetRound(int roundNumber)
        {
            foreach (Round r in Rounds)
            {
                if (r.Number == roundNumber)
                {
                    return r;
                }
            }
            // Does not exist, create
            Round round = new Round(roundNumber);
            Rounds.Add(round);
            return round;
        }

        public List<BoardResult> Score(IScoringEngine engine)
        {
            List<BoardResult> ret = new List<BoardResult>();
            foreach (Round round in Rounds)
            {
                ret.AddRange(round.Score(engine));
            }
            return ret;
        }

        public int GetMaxRoundNr()
        {
            int maxRoundNr = 1;
            foreach (Round r in Rounds)
            {
                if (r.Number > maxRoundNr)
                {
                    maxRoundNr = r.Number;
                }
            }
            return maxRoundNr;
        }

        public Result GetResult(int roundNumber, int boardNumber, int tableNumber)
        {
            Round round = GetRound(roundNumber);
            return round.GetResult(boardNumber, tableNumber);
        }
    }
}