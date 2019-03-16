using Scoring.Game;

namespace Scoring.HTML.Mapping
{
    public static class HTMLDirectionMapper
    {
        public static string GetstringFromDirection(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    return "North";
                case Direction.South:
                    return "South";
                case Direction.West:
                    return "West";
                case Direction.East:
                    return "East";
                default:
                    return "Unknown";
            }
        }
    }
}