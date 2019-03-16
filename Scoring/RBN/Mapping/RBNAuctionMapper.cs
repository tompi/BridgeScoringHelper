using Scoring.Game;
using Scoring.PBN.Mapping;

namespace Scoring.RBN.Mapping
{
    public static class RBNAuctionMapper
    {

        public static Vulnerability GetVulnerabilityFromstring(string auction)
        {
            return RBNVulnerabilityMapper.GetVulnerabilityFromChar(auction[1]);
        }

        public static Auction GetAuctionFromstring(string auction)
        {
            if (string.IsNullOrEmpty(auction))
            {
                return null;
            }
            Direction dealer = PBNDirectionMapper.GetDirectionFromstring(auction[0]);
            Auction ret = new Auction(dealer);
            int i = 3;
            while (i < auction.Length)
            {
                Bid b = null;
                char c = auction[i];
                switch (c)
                {
                    case 'P':
                        b = new Bid();
                        b.Pass = true;
                        break;
                    case 'X':
                        b = new Bid();
                        b.Double = true;
                        break;
                    case 'R':
                        b = new Bid();
                        b.ReDouble = true;
                        break;
                    case 'Y':
                        b = new Bid();
                        b.YourTurn = true;
                        break;
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                        b = new Bid();
                        b.Level = c - 48;
                        i++;
                        if (auction[i] == 'N')
                        {
                            b.Suit = Suit.Notrump;
                            i++;
                        }
                        else
                        {
                            b.Suit = PBNSuitMapper.GetSuitFromstring(auction.Substring(i, 1));
                        }

                        break;
                }

                // Check if there is a preceding "comment" of the bid
                if (b != null)
                {
                    ret.Bids.Add(b);
                    if (i + 1 < auction.Length)
                    {
                        switch (auction[i + 1])
                        {
                            case '?':
                                i++;
                                if ((i + 1 < auction.Length)
                                        && auction[i + 1] == '!')
                                {
                                    i++;
                                    b.Quality = BidQuality.Questionable;
                                }
                                else if ((i + 1 < auction.Length)
                                      && auction[i + 1] == '?')
                                {
                                    i++;
                                    b.Quality = BidQuality.VeryPoor;
                                }
                                else
                                {
                                    b.Quality = BidQuality.Poor;
                                }
                                break;
                            case '!':
                                i++;
                                if ((i + 1 < auction.Length)
                                        && auction[i + 1] == '!')
                                {
                                    i++;
                                    b.Quality = BidQuality.VeryGood;
                                }
                                else if ((i + 1 < auction.Length)
                                      && auction[i + 1] == '?')
                                {
                                    i++;
                                    b.Quality = BidQuality.Speculative;
                                }
                                else
                                { // Check if there is a preceding "comment" of
                                  // the bid
                                    if (i + 1 < auction.Length)
                                    {
                                        switch (auction[i + 1])
                                        {
                                            case '?':
                                                i++;
                                                if ((i + 1 < auction.Length)
                                                        && auction[i + 1] == '!')
                                                {
                                                    i++;
                                                    b.Quality = BidQuality.Questionable;
                                                }
                                                else if ((i + 1 < auction.Length)
                                                      && auction[i + 1] == '?')
                                                {
                                                    i++;
                                                    b.Quality = BidQuality.VeryPoor;
                                                }
                                                else
                                                {
                                                    b.Quality = BidQuality.Poor;
                                                }
                                                break;
                                            case '!':
                                                i++;
                                                if ((i + 1 < auction.Length)
                                                        && auction[i + 1] == '!')
                                                {
                                                    i++;
                                                    b.Quality = BidQuality.VeryGood;
                                                }
                                                else if ((i + 1 < auction.Length)
                                                      && auction[i + 1] == '?')
                                                {
                                                    i++;
                                                    b.Quality = BidQuality.Speculative;
                                                }
                                                else
                                                {
                                                    b.Quality = BidQuality.Good;
                                                }
                                                break;
                                            case '*':
                                                i++;
                                                b.Conventional = true;
                                                break;
                                            case '^':
                                                i += 2;
                                                b.Explanation = int.Parse(auction
                                                        .Substring(i, 1));
                                                break;
                                        }
                                    }

                                    b.Quality = BidQuality.Good;
                                }
                                break;
                            case '*':
                                i++;
                                b.Conventional = true;
                                break;
                            case '^':
                                i += 2;
                                b.Explanation = int.Parse(auction.Substring(i, 1));
                                break;
                        }
                    }
                }

                i++;
            }

            return ret;
        }
    }
}