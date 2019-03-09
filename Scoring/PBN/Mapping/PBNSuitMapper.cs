public static class PBNSuitMapper
{

    public static Suit GetSuitFromstring(string suit)
    {
        if ("N".Equals(suit) || "NT".Equals(suit))
        {
            return Suit.Notrump;
        }
        else if ("S".Equals(suit))
        {
            return Suit.Spades;
        }
        else if ("H".Equals(suit))
        {
            return Suit.Hearts;
        }
        else if ("D".Equals(suit))
        {
            return Suit.Diamonds;
        }
        else
        {
            return Suit.Clubs;
        }
    }

    public static string GetstringFromSuit(Suit suit)
    {
        switch (suit)
        {
            case Suit.Notrump:
                return "NT";
            case Suit.Spades:
                return "S";
            case Suit.Hearts:
                return "H";
            case Suit.Diamonds:
                return "D";
            default:
                return "C";
        }
    }
}
