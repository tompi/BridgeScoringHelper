using System.Text;
using Scoring.Game;

namespace Scoring.PBN.Mapping
{
    public static class PBNHandMapper
    {

        public static Hand GetHandFromstring(string hand)
        {
            if (hand == null || hand == "-" || hand.Length < 1)
            {
                return null;
            }
            Suit suit = Suit.Spades;
            int ix = 0;
            Hand ret = new Hand();

            foreach (char c in hand)
            {
                if (c == '.')
                {
                    suit = GetSuitBelow(suit);
                }
                else
                {
                    Card card = new Card(suit,
                            PBNDenominationMapper.GetDenominationFromChar(c));
                    ret.Cards[ix] = card;
                    ix++;
                }
            }

            return ret;
        }

        private static Suit GetSuitBelow(Suit suit)
        {
            switch (suit)
            {
                case Suit.Spades:
                    return Suit.Hearts;
                case Suit.Hearts:
                    return Suit.Diamonds;
                default:
                    return Suit.Clubs;
            }
        }

        public static string GetstringFromHand(Hand hand)
        {
            if (hand == null || hand.Cards == null || hand.Cards.Length < 1)
            {
                return "-";
            }
            var spades = new StringBuilder("");
            var hearts = new StringBuilder(".");
            var diamonds = new StringBuilder(".");
            var clubs = new StringBuilder(".");

            foreach (Card card in hand.Cards)
            {
                if (card != null)
                {
                    char symbol = PBNDenominationMapper
                            .GetCharFromDenomination(card.Denomination);
                    switch (card.Suit)
                    {
                        case Suit.Spades:
                            spades.Append(symbol);
                            break;
                        case Suit.Hearts:
                            hearts.Append(symbol);
                            break;
                        case Suit.Diamonds:
                            diamonds.Append(symbol);
                            break;
                        default:
                            clubs.Append(symbol);
                            break;
                    }
                }
            }
            return spades.Append(hearts).Append(diamonds).Append(clubs).ToString();
        }
    }
}