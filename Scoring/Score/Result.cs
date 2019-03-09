using System;

public class Result : IComparable {
	public Contract Contract { get; }
    public Board Board { get; }
    public Table Table { get; }
    public int NorthSouthPoints { get; }
    public double NorthSouthScore { get; set; }

    public Result(Contract contract, Board board, Table table) {
		Contract = contract;
		Board = board;
		Table = table;
		NorthSouthPoints = Calculator.GetNorthSouthPoints(Contract, Board);
	}

	public int CompareTo(object other) {
        if (!(other is Result result))
        {
            return 1;
        }
        return NorthSouthScore.CompareTo(result.NorthSouthScore);
	}
}
