using Scoring.Game;
using Scoring.RBN.Mapping;

namespace Scoring.RBN
{
    public class RBNAuction : RBNLine
    {
        public Auction Auction;
        public Vulnerability Vulnerability;

        public override string GetRBNstring()
        {
            return null;
        }

        public override void ParseRBNstring(string rbn)
        {
            if (!string.IsNullOrEmpty(rbn))
            {
                Auction = RBNAuctionMapper.GetAuctionFromstring(rbn);
                Vulnerability = RBNAuctionMapper.GetVulnerabilityFromstring(rbn);
            }
        }

        public override RBNLineType GetRBNLineType()
        {
            return RBNLineType.Auction;
        }

    }
}