using System;
using System.Collections.Generic;
using Scoring.Game;
using Scoring.Players;
using Scoring.Score;

namespace Scoring.Tournament
{
    public class Tournament
    {
        public DateTime Started;
        public string Name;
        public List<Pair> Pairs;
        public List<Session> Sessions;

        private IScoringEngine _scoringEngine;

        public Tournament()
        {
            Pairs = new List<Pair>();
            Sessions = new List<Session>();
        }

        public Pair GetPair(int pairNumber)
        {
            foreach (Pair p in Pairs)
            {
                if (p.Number == pairNumber)
                {
                    return p;
                }
            }
            return null;
        }

        public void AddScore(int sessionNumber, int roundNumber, Table table,
                Contract contract, int boardNumber)
        {
            Session session = GetSession(sessionNumber);
            session.AddContract(roundNumber, table, contract, boardNumber);
        }

        public Result GetResult(int sessionNumber, int roundNumber,
                int boardNumber, int tableNumber)
        {
            Session session = GetSession(sessionNumber);
            return session.GetResult(roundNumber, boardNumber, tableNumber);
        }

        public Session GetSession(int sessionNumber)
        {
            foreach (Session session in Sessions)
            {
                if (session.Number == sessionNumber)
                {
                    return session;
                }
            }
            // Does not exist, create
            Session s = new Session();
            s.Number = sessionNumber;
            return s;
        }

        public void Score(ScoringType scoringType)
        {
            // Clear old scores:
            foreach (Pair pair in Pairs)
            {
                pair.Score = 0;
            }
            // Score all sessions
            if (scoringType == ScoringType.MatchPoints)
            {
                _scoringEngine = new MatchPointsScoringEngine();
            }
            else if (scoringType == ScoringType.IMPsAcross)
            {
                _scoringEngine = new IMPsAcrossScoringEngine();
            }
            var results = new List<BoardResult>();
            foreach (Session session in Sessions)
            {
                results.AddRange(session.Score(_scoringEngine));
            }
            // Aggregate pair scores
            foreach (BoardResult br in results)
            {
                foreach (Result result in br.Results)
                {
                    result.Table.NorthSouthPair.Score += result.NorthSouthScore;
                    result.Table.EastWestPair.Score -= result.NorthSouthScore;
                }
            }
            // Sort Pair list:
            Pairs.Sort();
        }

        public int GetMaxSessionNr()
        {
            int maxSessionNr = 1;
            foreach (Session s in Sessions)
            {
                if (s.Number > maxSessionNr)
                {
                    maxSessionNr = s.Number;
                }
            }
            return maxSessionNr;
        }
    }
}