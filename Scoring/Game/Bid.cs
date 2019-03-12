public class Bid
{
    public bool Pass { get; set; }
    public int Level { get; set; }
    public Suit Suit { get; set; }
    public bool Double { get; set; }
    public bool ReDouble { get; set; }
    public int Explanation { get; set; }
    public bool Conventional { get; set; }
    public BidQuality? Quality { get; set; }
    public bool YourTurn { get; set; }
}