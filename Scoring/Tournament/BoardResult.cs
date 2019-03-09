using System.Collections.Generic;

public class BoardResult {
	public Board Board { get; }
    public List<Result> Results { get; }

    public BoardResult(Board board) {
		Board = board;
		Results = new List<Result>();
	}

	public void AddContract(Contract contract, Table table) {
		Results.Add(new Result(contract, Board, table));
	}

	public void Score(IScoringEngine engine) {
		engine.ScoreBoard(Results);
	}

	public void Sort() {
        Results.Sort();
	}
}
