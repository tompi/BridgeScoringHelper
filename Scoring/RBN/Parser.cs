using System.Collections.Generic;
using System.IO;
using Scoring.RBN.Mapping;

namespace Scoring.RBN
{
    public class RBNParser
    {

        public RBNArticle Parse(StreamReader rbnStream)
        {
            RBNArticle article = new RBNArticle();

            RBNHands currentHands = null;
            RBNAuction currentAuction = null;
            string line;
            while ((line = rbnStream.ReadLine()) != null)
            {
                RBNLine rbnLine = RBNLineMapper.GetRBNLine(line);
                if (rbnLine != null)
                {
                    switch (rbnLine.GetRBNLineType())
                    {
                        case RBNLineType.Hands:
                            currentHands = (RBNHands)rbnLine;
                            article.Add(rbnLine);
                            break;
                        case RBNLineType.Auction:
                            currentAuction = (RBNAuction)rbnLine;
                            if (currentHands != null)
                            {
                                currentHands.Vulnerability = currentAuction.Vulnerability;
                                currentHands.Dealer = currentAuction.Auction.Dealer;
                            }
                            article.Add(rbnLine);
                            break;
                        case RBNLineType.BidExplanation:
                            if (currentAuction != null)
                            {
                                currentAuction.Auction.Explanations
                                        .Add(((RBNBidExplanation)rbnLine).Explanation);
                            }
                            break;
                        default:
                            article.Add(rbnLine);
                            break;
                    }

                }
            }
            return article;
        }
    }
}