using System.Collections.Generic;

public class Auction {
	public List<Bid> Bids { get; }
    public List<string> Explanations { get; }
    public Direction Dealer { get; }

    public Auction(Direction dealer) {
		Dealer = dealer;
		Bids = new List<Bid>();
		Explanations = new List<string>();
	}
}
