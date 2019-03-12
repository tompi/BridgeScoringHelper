using Xunit;

public class NeubergCalculatorTest {

	[Fact]
	public void testGetAdjustedScore_4p_6p_7sp() {
		NeubergCalculator calc = new NeubergCalculator(6, 7);
		int actual = calc.GetAdjustedScoreTimes10(4);
		Assert.Equal(48, actual);
	}

	[Fact]
	public void testGetAdjustedScore_9p_6p_7sp() {
		NeubergCalculator calc = new NeubergCalculator(6, 7);
		int actual = calc.GetAdjustedScoreTimes10(9);
		Assert.Equal(107, actual);
	}

}
