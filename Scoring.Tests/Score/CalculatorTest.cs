using Xunit;

public class CalculatorTest {
	private Board boardVulnerable;
	private Board boardNotVulnerable;

	public CalculatorTest() {
		boardNotVulnerable = new Board(1);
		boardVulnerable = new Board(4);
	}

	[Fact]
	public void testGetNorthSouthScore_4HV10_equals_620() {
		Contract contract = new Contract();
		contract.Level = 4;
		contract.Player = Direction.North;
		contract.Doubled = false;
		contract.ReDoubled = false;
		contract.Suit = Suit.Hearts;
		contract.Tricks = 10;
		int actual = Calculator.GetNorthSouthPoints(contract, boardVulnerable);

		Assert.Equal(620, actual);
	}

	[Fact]
	public void testGetNorthSouthScore_4HXV7_equals_minus800() {
		Contract contract = new Contract();
		contract.Level = 4;
		contract.Player = Direction.North;
		contract.Doubled = true;
		contract.ReDoubled = false;
		contract.Suit = Suit.Hearts;
		contract.Tricks = 7;
		int actual = Calculator.GetNorthSouthPoints(contract, boardVulnerable);

		Assert.Equal(-800, actual);
	}

	[Fact]
	public void testGetNorthSouthScore_2HVW8_equals_minus110() {
		Contract contract = new Contract();
		contract.Level = 2;
		contract.Player = Direction.West;
		contract.Doubled = false;
		contract.ReDoubled = false;
		contract.Suit = Suit.Hearts;
		contract.Tricks = 8;
		int actual = Calculator.GetNorthSouthPoints(contract, boardVulnerable);

		Assert.Equal(-110, actual);
	}

	[Fact]
	public void testGetNorthSouthScore_2HXNVW8_equals_minus470() {
		Contract contract = new Contract();
		contract.Level = 2;
		contract.Player = Direction.West;
		contract.Doubled = true;
		contract.ReDoubled = false;
		contract.Suit = Suit.Hearts;
		contract.Tricks = 8;
		int actual = Calculator.GetNorthSouthPoints(contract,
				boardNotVulnerable);

		Assert.Equal(-470, actual);
	}

	[Fact]
	public void testGetNorthSouthScore_3NTVS11_equals_660() {
		Contract contract = new Contract();
		contract.Level = 3;
		contract.Player = Direction.South;
		contract.Doubled = false;
		contract.ReDoubled = false;
		contract.Suit = Suit.Notrump;
		contract.Tricks = 11;
		int actual = Calculator.GetNorthSouthPoints(contract, boardVulnerable);

		Assert.Equal(660, actual);
	}

	[Fact]
	public void testGetNorthSouthScore_1DX8NVW_equals_minus240() {
		Contract contract = new Contract();
		contract.Level = 1;
		contract.Player = Direction.West;
		contract.Doubled = true;
		contract.ReDoubled = false;
		contract.Suit = Suit.Diamonds;
		contract.Tricks = 8;
		int actual = Calculator.GetNorthSouthPoints(contract,
				boardNotVulnerable);

		Assert.Equal(-240, actual);
	}

	[Fact]
	public void testGetNorthSouthScore_5SXX12VW_equals_minus1600() {
		Contract contract = new Contract();
		contract.Level = 5;
		contract.Player = Direction.West;
		contract.Doubled = true;
		contract.ReDoubled = true;
		contract.Suit = Suit.Spades;
		contract.Tricks = 12;
		int actual = Calculator.GetNorthSouthPoints(contract, boardVulnerable);

		Assert.Equal(-1600, actual);
	}

	[Fact]
	public void testGetNorthSouthScore_6NT13NVW_equals_minus1020() {
		Contract contract = new Contract();
		contract.Level = 6;
		contract.Player = Direction.West;
		contract.Doubled = false;
		contract.ReDoubled = false;
		contract.Suit = Suit.Notrump;
		contract.Tricks = 13;
		int actual = Calculator.GetNorthSouthPoints(contract,
				boardNotVulnerable);

		Assert.Equal(-1020, actual);
	}

	[Fact]
	public void testGetNorthSouthScore_4D7NVW_equals_150() {
		Contract contract = new Contract();
		contract.Level = 4;
		contract.Player = Direction.West;
		contract.Doubled = false;
		contract.ReDoubled = false;
		contract.Suit = Suit.Diamonds;
		contract.Tricks = 7;
		int actual = Calculator.GetNorthSouthPoints(contract,
				boardNotVulnerable);

		Assert.Equal(150, actual);
	}

	[Fact]
	public void testGetNorthSouthScore_4DX7NVW_equals_500() {
		Contract contract = new Contract();
		contract.Level = 4;
		contract.Player = Direction.West;
		contract.Doubled = true;
		contract.ReDoubled = false;
		contract.Suit = Suit.Diamonds;
		contract.Tricks = 7;
		int actual = Calculator.GetNorthSouthPoints(contract,
				boardNotVulnerable);

		Assert.Equal(500, actual);
	}

	[Fact]
	public void testGetNorthSouthScore_4Dx7VW_equals_800() {
		Contract contract = new Contract();
		contract.Level = 4;
		contract.Player = Direction.West;
		contract.Doubled = true;
		contract.ReDoubled = false;
		contract.Suit = Suit.Diamonds;
		contract.Tricks = 7;
		int actual = Calculator.GetNorthSouthPoints(contract, boardVulnerable);

		Assert.Equal(800, actual);
	}

}
