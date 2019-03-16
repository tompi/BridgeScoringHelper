using Scoring.Game;

namespace Scoring.PBN.Mapping
{
    public static class PBNBidMapper
    {

        /*
        public static Bid GetBidFromstring(string bid)
        {
            // TODO
            return null;
        }
        */

        public static string GetstringFromBid(Bid bid)
        {
            if (bid == null)
            {
                return "-";
            }
            return GetCall(bid) + GetNote(bid.Explanation) + GetNAG(bid.Quality);
        }

        private static string GetNAG(BidQuality? quality)
        {
            if (quality == null) return "";
            switch (quality)
            {
                case BidQuality.Good:
                    return " $1";
                case BidQuality.Poor:
                    return " $2";
                case BidQuality.VeryGood:
                    return " $3";
                case BidQuality.VeryPoor:
                    return " $4";
                case BidQuality.Speculative:
                    return " $5";
                case BidQuality.Questionable:
                    return " $6";
                default:
                    return "";
            }
        }

        private static string GetCall(Bid bid)
        {
            if (bid.Pass)
            {
                return "Pass";
            }
            if (bid.ReDouble)
            {
                return "XX";
            }
            if (bid.Double)
            {
                return "X";
            }
            return bid.Level.ToString()
                    + PBNSuitMapper.GetstringFromSuit(bid.Suit);
        }

        private static string GetNote(int note)
        {
            if (note < 1)
            {
                return "";
            }
            return " =" + note.ToString() + "=";
        }
    }
}