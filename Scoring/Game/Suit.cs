public enum Suit
{
    Clubs, Diamonds, Hearts, Spades, Notrump
}

public static class SuitExtensions
{ 
    public static bool IsMajor(this Suit suit) {
		return (suit == Suit.Spades || suit == Suit.Hearts);
	}

	public static bool IsMinor(this Suit suit) {
		return (suit == Suit.Clubs || suit == Suit.Diamonds);
	}

	public static int PointsPerTrick(this Suit suit) {
		return suit.IsMinor() ? 20 : 30;
	}

	public static int ExtraPointsForFirstTrick(this Suit suit) {
		return suit == Suit.Notrump ? 10 : 0;
	}

}
