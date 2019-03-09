public static class HTMLSuitMapper
{
    public static string GetstringFromSuit(Suit suit)
    {
        switch (suit)
        {
            case Suit.Spades:
                return "&spades;";
            case Suit.Hearts:
                return "<span class=\"red\">&hearts;</span>";
            case Suit.Diamonds:
                return "<span class=\"red\">&diams;</span>";
            case Suit.Clubs:
                return "&clubs;";
            default:
                return "NT";
        }
    }
}
