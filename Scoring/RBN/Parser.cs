using System.IO;

public class RBNParser
{

    public RBNArticle Parse(StringReader rbn)
    {
        RBNArticle article = new RBNArticle();
        string line = null;

        RBNHands currentHands = null;
        RBNAuction currentAuction = null;
        while ((line = rbn.ReadLine()) != null)
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
