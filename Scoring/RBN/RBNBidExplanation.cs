// NB: Custom extension to RBN
namespace Scoring.RBN
{
    public class RBNBidExplanation : RBNLine
    {
        public string Explanation;


        override public string GetRBNstring()
        {
            return "";
        }

        override public void ParseRBNstring(string rbn)
        {
            Explanation = rbn;
        }

        override public RBNLineType GetRBNLineType()
        {
            return RBNLineType.BidExplanation;
        }

    }
}