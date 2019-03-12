﻿using System.Collections.Generic;
using Xunit;

public class IMPsAcrossScoringEngineTest {
	private List<Result> smallResult;
	private Result res1;
	private Result res2;
	private Result res3;
	private IMPsAcrossScoringEngine engine = new IMPsAcrossScoringEngine();
	private Result GetEmptyResult() {
		return new Result(new Contract(), new Board(1), new Table());
	}

  	public IMPsAcrossScoringEngineTest() {
		smallResult = new List<Result>();
		res1 = GetEmptyResult();
		res1.NorthSouthPoints = 100;
		smallResult.Add(res1);
		res2 = GetEmptyResult();
		res2.NorthSouthPoints = 500;
		smallResult.Add(res2);
		res3 = GetEmptyResult();
		res3.NorthSouthPoints = 500;
		smallResult.Add(res3);
		engine.ScoreBoard(smallResult);
	}

	[Fact]
	public void testScoreBoard_2xminus400_equals_minus18() {
		Assert.Equal(-18, (int)res1.NorthSouthScore);
	}
	[Fact]
	public void testScoreBoard_1x400_equals_9() {
		Assert.Equal(9, (int)res2.NorthSouthScore);
	}

}
