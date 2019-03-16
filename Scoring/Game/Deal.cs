namespace Scoring.Game
{
    public class Deal
    {
        public Hand West;
        public Hand North;
        public Hand East;
        public Hand South;

        public Hand getHand(Direction direction)
        {
            switch (direction)
            {
                case Direction.West:
                    return West;
                case Direction.North:
                    return North;
                case Direction.East:
                    return East;
                case Direction.South:
                    return South;
                default:
                    return null;
            }
        }

        public void setHand(Direction direction, Hand hand)
        {
            switch (direction)
            {
                case Direction.West:
                    West = hand;
                    break;
                case Direction.North:
                    North = hand;
                    break;
                case Direction.East:
                    East = hand;
                    break;
                case Direction.South:
                    South = hand;
                    break;
                default:
                    return;
            }
        }

        public bool contains(Card card)
        {
            if (West != null && West.Contains(card))
                return true;
            if (North != null && North.Contains(card))
                return true;
            if (East != null && East.Contains(card))
                return true;
            if (South != null && South.Contains(card))
                return true;
            return false;
        }
    }
}