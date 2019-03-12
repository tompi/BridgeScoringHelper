using Xunit;

public class IMPCalculatorTest {
	private Board boardNotVulnerable;

	public IMPCalculatorTest() {
		boardNotVulnerable = new Board(1);
	}

	[Fact]
	public void testGetNorthSouthIMPIntInt_100_equals_3() {
		int actual = IMPCalculator.GetNorthSouthIMP(200, 100);

		Assert.Equal(3, actual);
	}

	[Fact]
	public void testGetNorthSouthIMPIntInt_minus100_equals_minus3() {
		int actual = IMPCalculator.GetNorthSouthIMP(200, 300);

		Assert.Equal(-3, actual);
	}

	[Fact]
	public void testGetNorthSouthIMPIntInt_10_equals_0() {
		int actual = IMPCalculator.GetNorthSouthIMP(430, 420);

		Assert.Equal(0, actual);
	}

	[Fact]
	public void testGetNorthSouthIMPIntInt_3990_equals_23() {
		int actual = IMPCalculator.GetNorthSouthIMP(4010, 20);

		Assert.Equal(23, actual);
	}

	[Fact]
	public void testGetNorthSouthIMPIntInt_430_equals_10() {
		int actual = IMPCalculator.GetNorthSouthIMP(800, 370);

		Assert.Equal(10, actual);
	}

	[Fact]
	public void testGetNorthSouthIMPIntInt_490_equals_10() {
		int actual = IMPCalculator.GetNorthSouthIMP(800, 310);

		Assert.Equal(10, actual);
	}

	[Fact]
	public void testGetNorthSouthIMPIntInt_4000_equals_24() {
		int actual = IMPCalculator.GetNorthSouthIMP(4300, 300);

		Assert.Equal(24, actual);
	}

	[Fact]
	public void testGetNorthSouthIMPIntInt_8000_equals_24() {
		int actual = IMPCalculator.GetNorthSouthIMP(8000, 0);

		Assert.Equal(24, actual);
	}

	[Fact]
	public void testGetNorthSouthIMPContractContract() {
		Contract contractA = new Contract();
		contractA.Level = 4;
		contractA.Player = Direction.West;
		contractA.Doubled = true;
		contractA.ReDoubled = false;
		contractA.Suit = Suit.Diamonds;
		contractA.Tricks = 7;

		Contract contractB = new Contract();
		contractB.Level = 4;
		contractB.Player = Direction.West;
		contractB.Doubled = true;
		contractB.ReDoubled = false;
		contractB.Suit = Suit.Diamonds;
		contractB.Tricks = 8;

		int northIMP = IMPCalculator.GetNorthSouthIMP(boardNotVulnerable,
				contractA, contractB);

		Assert.Equal(5, northIMP);
	}

}
