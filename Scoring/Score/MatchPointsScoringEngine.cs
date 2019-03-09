using System.Collections.Generic;

public class MatchPointsScoringEngine : IScoringEngine
{

	public void ScoreBoard(List<Result> results) {
		for (int i=0; i<results.Count; i++) {
			int nsScore = 0;
			Result result = results[i];
			int nsPoints = result.NorthSouthPoints;
			for (int j=0; j<results.Count; j++) {
				if (j != i ) {
					int nsPointsTableB = results[j].NorthSouthPoints;
					if (nsPoints > nsPointsTableB) {
						nsScore += 2;
					} else if (nsPoints == nsPointsTableB) {
						nsScore += 1;
					}
				}
			}
			result.NorthSouthScore = (double)nsScore;
		}
		
	}
}
