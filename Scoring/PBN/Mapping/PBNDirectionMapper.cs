public static class PBNDirectionMapper
{

    public static Direction GetDirectionFromstring(char direction)
    {
        if (direction == 'W')
        {
            return Direction.West;
        }
        else if (direction == 'E')
        {
            return Direction.East;
        }
        else if (direction == 'S')
        {
            return Direction.South;
        }
        else
        {
            return Direction.North;
        }
    }

    public static string GetstringFromDirection(Direction direction)
    {
        switch (direction)
        {
            case Direction.West:
                return "W";
            case Direction.East:
                return "E";
            case Direction.South:
                return "S";
            default:
                return "N";
        }
    }
}
