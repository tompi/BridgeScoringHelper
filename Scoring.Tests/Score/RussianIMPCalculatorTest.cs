using Xunit;

public class RussianIMPCalculatorTest {

	[Fact]
	public void testGetResult_20_v_equals_0() {
		int actual = RussianIMPCalculator.GetExpectedResult(20, true);

		Assert.Equal(0, actual);
	}

	[Fact]
	public void testGetResult_40_v_equals_1950() {
		int actual = RussianIMPCalculator.GetExpectedResult(40, true);

		Assert.Equal(1950, actual);
	}

	[Fact]
	public void testGetResult_18_v_equals_minus70() {
		int actual = RussianIMPCalculator.GetExpectedResult(18, true);

		Assert.Equal(-70, actual);
	}

	[Fact]
	public void testGetResult_32_nv_equals_700() {
		int actual = RussianIMPCalculator.GetExpectedResult(32, false);

		Assert.Equal(700, actual);
	}

	[Fact]
	public void testGetIMP_170_24_v_equals_minus3() {
		int actual = RussianIMPCalculator.GetIMP(170, 24, true, false);

		Assert.Equal(-3, actual);
	}

	[Fact]
	public void testGetIMP_420_18_nv_equals_10() {
		int actual = RussianIMPCalculator.GetIMP(420, 18, false, false);

		Assert.Equal(10, actual);
	}

	[Fact]
	public void testGetIMP_550_27_nv_equals_10() {
		int actual = RussianIMPCalculator.GetIMP(550, 27, false, false);

		Assert.Equal(4, actual);
	}

	[Fact]
	public void testGetIMP_minus50_12_nv_v_equals_11() {
		int actual = RussianIMPCalculator.GetIMP(-50, 12, false, true);

		Assert.Equal(11, actual);
	}

}
