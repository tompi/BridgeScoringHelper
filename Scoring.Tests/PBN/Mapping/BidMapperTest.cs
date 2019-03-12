using System;
using Xunit;

namespace Scoring.Tests.Score.PBN.Mapping
{
    public class BidMapperTest {

        [Fact]
        public void test3NTmapsTo3NT() {
            Bid b = new Bid();
            b.Level = 3;
            b.Suit = Suit.Notrump;

            Assert.Equal("3NT", PBNBidMapper.GetstringFromBid(b));
        }

        [Fact]
        public void test3NTVeryPoormapsTo3NT() {
            Bid b = new Bid();
            b.Level = 3;
            b.Suit = Suit.Notrump;
            b.Quality = BidQuality.VeryPoor;

            Assert.Equal("3NT $4", PBNBidMapper.GetstringFromBid(b));
        }

        [Fact]
        public void test4HwithcommentsVeryGoodMapsTo4Hcorrectly() {
            Bid b = new Bid();
            b.Level = 4;
            b.Suit = Suit.Hearts;
            b.Quality = BidQuality.VeryGood;
            b.Explanation = 5;

            Assert.Equal("4H =5= $3", PBNBidMapper.GetstringFromBid(b));
        }

        [Fact]
        public void test2SwithcommentsMapsTo2Scorrectly() {
            Bid b = new Bid();
            b.Level = 2;
            b.Suit = Suit.Spades;
            b.Explanation = 2;

            Assert.Equal("2S =2=", PBNBidMapper.GetstringFromBid(b));
        }

        [Fact]
        public void testPassMapsToPass() {
            Bid b = new Bid();
            b.Pass = true;

            Assert.Equal("Pass", PBNBidMapper.GetstringFromBid(b));
        }

        [Fact]
        public void testRedoubleSpeculativeMapsToXXCorrectly() {
            Bid b = new Bid();
            b.ReDouble = true;
            b.Quality = BidQuality.Speculative;

            Assert.Equal("XX $5", PBNBidMapper.GetstringFromBid(b));
        }

        [Fact]
        public void testDoubleMapsToX() {
            Bid b = new Bid();
            b.Double = true;

            Assert.Equal("X", PBNBidMapper.GetstringFromBid(b));
        }
    }
}