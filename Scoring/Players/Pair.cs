using System;

public class Pair : IComparable
{
    public Person NorthEast { get; set; }
    public Person SouthWest { get; set; }
    public double Score { get; set; }
    public int Number { get; set; }

    public int CompareTo(object obj)
    {
        if (!(obj is Pair other))
        {
            return 1;
        }
        return Score.CompareTo(other.Score);
    }

    public string GetDisplayName() {
		return NorthEast.DisplayName + "/" + SouthWest.DisplayName;
	}
}
