using System.Text;

public static class PBNAuctionMapper
{

    /*
	public static Auction GetAuctionFromStream(InputStream identification) {
		// TODO
		return null;
	}
	*/

    public static void AppendAuction(StringBuilder pbn, PBNAuction pbnAuction)
    {
        if (pbnAuction == null || pbnAuction.Auction == null
                || pbnAuction.Auction.Bids == null
                || pbnAuction.Auction.Bids.Count < 1)
        {
            return;
        }
        var auction = pbnAuction.Auction;
        PBNTagMapper.AppendTag(pbn, PBNAuction.Tags.Auction, auction.Dealer);

        int ix = 1;
        foreach (Bid b in auction.Bids)
        {
            pbn.Append(PBNBidMapper.GetstringFromBid(b));
            if (ix == auction.Bids.Count)
            {
                pbn.Append('\n');
            }
            else
            {
                if (ix % 4 == 0)
                {
                    pbn.Append('\n');
                }
                else
                {
                    pbn.Append(' ');
                }
            }
            ix++;
        }
        ix = 1;
        foreach (string explanation in auction.Explanations)
        {
            PBNTagMapper.AppendTag(pbn, PBNAuction.Tags.Note, ix.ToString()
                    + ":" + explanation);
            ix++;
        }
    }
}