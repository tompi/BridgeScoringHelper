using System.Collections.Generic;
using System.Text;

public static class HTMLAuctionMapper
{

    public static void AppendAuction(StringBuilder html, Auction auction)
    {
        if (auction == null)
        {
            return;
        }
        html.Append("<div>");
        html.Append("<table cellspacing=\"0\" cellpadding=\"4\" border=\"1px\">");
        html.Append("<colgroup><col span=\"4\" align=\"center\"/></colgroup>");
        html.Append("<tr>");
        html.Append("<th><b>"
                + HTMLDirectionMapper.GetstringFromDirection(Direction.West)
                + "</b></th>");
        html.Append("<th><b>"
                + HTMLDirectionMapper.GetstringFromDirection(Direction.North)
                + "</b></th>");
        html.Append("<th><b>"
                + HTMLDirectionMapper.GetstringFromDirection(Direction.East)
                + "</b></th>");
        html.Append("<th><b>"
                + HTMLDirectionMapper.GetstringFromDirection(Direction.South)
                + "</b></th></tr>");

        // Make "balanced" array of bids:
        var bids = new List<Bid>();
        if (auction.Dealer == Direction.South)
        {
            bids.Add(null);
            bids.Add(null);
            bids.Add(null);
        }
        if (auction.Dealer == Direction.East)
        {
            bids.Add(null);
            bids.Add(null);
        }
        if (auction.Dealer == Direction.West)
        {
            bids.Add(null);
        }
        bids.AddRange(auction.Bids);

        for (int i = 0; i < (bids.Count / 4) + 1; i++)
        {
            int ix = i * 4;
            html.Append("<tr>");
            AddBid(html, bids, ix);
            AddBid(html, bids, ix + 1);
            AddBid(html, bids, ix + 2);
            AddBid(html, bids, ix + 3);
            html.Append("</tr>");
        }

        html.Append("</table></div>");

    }

    private static void AddBid(StringBuilder html, List<Bid> bids, int i)
    {
        html.Append("<td>");
        Bid b = null;
        if (i < bids.Count)
        {
            b = bids[i];
        }

        if (b != null)
        {
            HTMLBidMapper.AppendBid(html, b);
        }
        else
        {
            html.Append("&nbsp;");
        }
        html.Append("</td>");
    }
}
