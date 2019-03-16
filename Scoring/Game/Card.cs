namespace Scoring.Game
{
    public class Card
    {
        public Suit Suit { get; }
        public Denomination Denomination { get; }

        public Card(Suit suit, Denomination denomination)
        {
            Suit = suit;
            Denomination = denomination;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Card))
            {
                return false;
            }
            Card other = (Card)obj;
            if (other.Suit == Suit && other.Denomination == Denomination)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -613796032;
            hashCode = hashCode * -1521134295 + Suit.GetHashCode();
            hashCode = hashCode * -1521134295 + Denomination.GetHashCode();
            return hashCode;
        }
    }
}