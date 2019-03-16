using Scoring.Score;
using Xunit;

namespace Scoring.Tests.Score
{
    public class VPCalculatorTest
    {

        [Fact]
        public void IMP0is15_15()
        {
            VPPoints actual = VPCalculator.GetWBFVP(0, 16);

            Assert.Equal(15, actual.WinnerVP);
        }

        [Fact]
        public void IMP130is25_0()
        {
            VPPoints actual = VPCalculator.GetWBFVP(130, 16);

            Assert.Equal(25, actual.WinnerVP);
            Assert.Equal(0, actual.LoserVP);
        }

        [Fact]
        public void IMP20Boards20is19_11()
        {
            VPPoints actual = VPCalculator.GetWBFVP(20, 20);

            Assert.Equal(19, actual.WinnerVP);
            Assert.Equal(11, actual.LoserVP);
        }

        [Fact]
        public void IMP15Boards32is17_13()
        {
            VPPoints actual = VPCalculator.GetWBFVP(15, 32);

            Assert.Equal(17, actual.WinnerVP);
            Assert.Equal(13, actual.LoserVP);
        }

        [Fact]
        public void IMP45Boards9is25_2()
        {
            VPPoints actual = VPCalculator.GetWBFVP(45, 9);

            Assert.Equal(25, actual.WinnerVP);
            Assert.Equal(2, actual.LoserVP);
        }

        [Fact]
        public void IMP4Boards48is15_15()
        {
            VPPoints actual = VPCalculator.GetWBFVP(4, 48);

            Assert.Equal(15, actual.WinnerVP);
            Assert.Equal(15, actual.LoserVP);
        }

        [Fact]
        public void IMP4Boards52is15_15()
        {
            VPPoints actual = VPCalculator.GetWBFVP(4, 52);

            Assert.Equal(15, actual.WinnerVP);
            Assert.Equal(15, actual.LoserVP);
        }

        [Fact]
        public void IMP15Boards19is18_12()
        {
            VPPoints actual = VPCalculator.GetWBFVP(15, 18);

            Assert.Equal(18, actual.WinnerVP);
            Assert.Equal(12, actual.LoserVP);
        }

        [Fact]
        public void IMP25Boards13is22_8()
        {
            VPPoints actual = VPCalculator.GetWBFVP(25, 13);

            Assert.Equal(22, actual.WinnerVP);
            Assert.Equal(8, actual.LoserVP);
        }

        [Fact]
        public void IMP43Boards11is25_3()
        {
            VPPoints actual = VPCalculator.GetWBFVP(43, 11);

            Assert.Equal(25, actual.WinnerVP);
            Assert.Equal(3, actual.LoserVP);
        }

    }
}