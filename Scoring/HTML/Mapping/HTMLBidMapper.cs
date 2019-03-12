using System.Text;

public static class HTMLBidMapper
{

    public static void AppendBid(StringBuilder html, Bid bid)
    {
        if (bid == null)
        {
            return;
        }
        AppendCall(html, bid);
        AppendQuality(html, bid.Quality);
        AppendNote(html, bid.Explanation);
    }

    private static void AppendCall(StringBuilder html, Bid bid)
    {
        if (bid.Pass)
        {
            html.Append("Pass");
        }
        else if (bid.ReDouble)
        {
            html.Append("XX");
        }
        else if (bid.Double)
        {
            html.Append("X");
        }
        else
        {
            html.Append(bid.Level.ToString()
                    + HTMLSuitMapper.GetstringFromSuit(bid.Suit));
        }
    }

    private static void AppendQuality(StringBuilder html, BidQuality? quality)
    {
        if (quality == null) return;
        switch (quality)
        {
            case BidQuality.Good:
                html.Append("!");
                break;
            case BidQuality.Poor:
                html.Append("?");
                break;
            case BidQuality.VeryGood:
                html.Append("!!");
                break;
            case BidQuality.VeryPoor:
                html.Append("??");
                break;
            case BidQuality.Speculative:
                html.Append("?!");
                break;
            case BidQuality.Questionable:
                html.Append("!?");
                break;
            default:
                return;
        }
    }

    private static void AppendNote(StringBuilder html, int explanation)
    {
        if (explanation > 0)
        {
            html.Append("<super>" + explanation.ToString() + "</super>");
        }
    }

}
