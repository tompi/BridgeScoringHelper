using System.Collections.Generic;

public class Round {
	public int Number;

	public List<BoardResult> BoardResults;

	public Round(int number) {
		Number = number;
		BoardResults = new List<BoardResult>();
	}

	public void AddBoardResult(BoardResult result) {
		BoardResults.Add(result);
	}

	public void AddContract(Contract contract, Table table, int boardNumber) {
		BoardResult boardResult = GetBoardResult(boardNumber);
		boardResult.AddContract(contract, table);
	}

	private BoardResult GetBoardResult(int boardNumber) {
		foreach (BoardResult b in BoardResults) {
			if (b.Board.Number == boardNumber) {
				return b;
			}
		}
		// Does not exist yet, create board:
		Board board = new Board(boardNumber);
		BoardResult boardResult = new BoardResult(board);
		AddBoardResult(boardResult);
		return boardResult;
	}

	public List<BoardResult> Score(IScoringEngine engine) {
		foreach (BoardResult res in BoardResults) {
			res.Score(engine);
		}
		return BoardResults;
	}

	public int GetMaxTableNr() {
		int maxTableNr = 0;
        foreach (BoardResult br in BoardResults) {
            foreach (Result r in br.Results) {
				if (r.Table.Number > maxTableNr) {
					maxTableNr = r.Table.Number;
				}
			}
		}
		return maxTableNr;
	}

	public Result GetResult(int boardNumber, int tableNumber) {
		BoardResult br = GetBoardResult(boardNumber);
        foreach (Result result in br.Results) {
			if (result.Table != null && result.Table.Number == tableNumber) {
				return result;
			}
		}
		return null;
	}
}
