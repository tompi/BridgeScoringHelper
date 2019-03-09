public enum Direction
{
    North,
    South,
    East,
    West
}

public static class DirectionExtensions
    {
	public static bool IsNorthSouth(this Direction direction)
	{
		return (direction == Direction.North || direction == Direction.South);
	}
}
