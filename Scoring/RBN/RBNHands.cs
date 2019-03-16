using Scoring.Game;
using Scoring.PBN.Mapping;

namespace Scoring.RBN
{
    public class RBNHands : RBNLine
    {
        public Deal Deal;
        public Vulnerability Vulnerability;
        public Direction Dealer;

        override public string GetRBNstring()
        {
            return PBNDealMapper.GetstringFromDeal(Deal).Replace(' ', ':');
        }

        override public void ParseRBNstring(string rbn)
        {
            if (!string.IsNullOrEmpty(rbn))
            {
                string pbn = rbn.Replace(':', ' ');
                pbn = pbn.Substring(0, 1) + ":" + pbn.Substring(2);
                Deal = PBNDealMapper.GetDealFromstring(pbn);
            }
        }

        override public RBNLineType GetRBNLineType()
        {
            return RBNLineType.Hands;
        }

    }
}